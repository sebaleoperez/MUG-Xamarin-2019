using System;
using HolaMundo.Views;
using Xamarin.Forms;

namespace HolaMundo.Selector
{
    public class ChatTemplateSelector : DataTemplateSelector
    {
        public DataTemplate EntranteTemplate { get; set; }
        public DataTemplate SalienteTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            Mensaje mensaje = (Mensaje)item;

            if (mensaje.Entrante) return EntranteTemplate;
            else return SalienteTemplate;
        }
    }
}
