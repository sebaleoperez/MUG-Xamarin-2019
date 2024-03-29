﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Android.Speech.Tts;
using HolaMundo.Interfaces;
using Xamarin.Forms;

namespace HolaMundo.Droid.Implementations
{
    public class TextToSpeechImplentation : Java.Lang.Object, ITextToSpeech, TextToSpeech.IOnInitListener,
#pragma warning disable CS0618
        TextToSpeech.IOnUtteranceCompletedListener
#pragma warning restore CS0618
    {
        TextToSpeech speaker;
        TaskCompletionSource<bool> tcsInitialize;
        TaskCompletionSource<bool> tcsUtterance;

        Task<bool> Initialize()
        {
            if (tcsInitialize != null)
                return tcsInitialize.Task;

            tcsInitialize = new TaskCompletionSource<bool>();
            try
            {
                speaker = new TextToSpeech(MainActivity.Instance, this);
#pragma warning disable CS0618
                speaker.SetOnUtteranceCompletedListener(this);
#pragma warning restore CS0618
            }
            catch (Exception ex)
            {
                tcsInitialize.TrySetException(ex);
            }
            return tcsInitialize.Task;
        }

        public async Task LeerEnVozAlta(string text)
        {
            await Initialize();

            if (tcsUtterance?.Task != null)
                await tcsUtterance.Task;

            tcsUtterance = new TaskCompletionSource<bool>();

            // Set the utterance id so the completed listener fires
            var parameters = new Dictionary<string, string>();
            parameters.Add(TextToSpeech.Engine.KeyParamUtteranceId, new Guid().ToString());

            // Use an obsolete overload so it works on older API levels
#pragma warning disable CS0618
            speaker.Speak(text, QueueMode.Flush, parameters);
#pragma warning restore CS0618
            await tcsUtterance.Task;
        }

        public void OnInit(OperationResult status)
        {
            if (status.Equals(OperationResult.Success))
                tcsInitialize.TrySetResult(true);
            else
                tcsInitialize.TrySetException(new ArgumentException("Failed to initialize TTS engine."));
        }

        public void OnUtteranceCompleted(string utteranceId)
        {
            tcsUtterance.TrySetResult(true);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                speaker?.Stop();
                speaker?.Shutdown();
                speaker = null;
            }

            base.Dispose(disposing);
        }
    }
}
