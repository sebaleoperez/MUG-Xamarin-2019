using System;
using System.Collections.Generic;
using HolaMundo.Interfaces;
using HolaMundo.ViewModels;
using Xamarin.Forms;
using Xamarin.Essentials;

namespace HolaMundo.Views
{
    public partial class LoginConMVVM : ContentPage
    {
        public LoginConMVVM()
        {
            InitializeComponent();

            //DependencyService.Get<ITextToSpeech>().LeerEnVozAlta("Bienvenidos! Por favor ingresá tu usuario");

            //TextToSpeech.SpeakAsync("Bienvenidos! Por favor ingresá tu usuario");

            var location = Geolocation.GetLastKnownLocationAsync().Result;

            //var location = new Location(47.645160, -122.1306032);
            var options = new MapLaunchOptions { Name = "Microsoft Building 25" };

            Map.OpenAsync(location, options);

        }
    }
}
