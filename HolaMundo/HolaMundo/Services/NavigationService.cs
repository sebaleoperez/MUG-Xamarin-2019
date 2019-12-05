using System;
using Xamarin.Forms;

namespace HolaMundo.Services
{
    public class NavigationService
    {
        public void AccionLoginValido()
        {
            // Podria tirar logs
            App.Current.MainPage = new NavigationPage(new ListadoNumeros());
        }
    }
}
