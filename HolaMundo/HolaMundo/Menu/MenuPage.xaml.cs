using System;
using System.Collections.Generic;
using HolaMundo.Views;
using Xamarin.Forms;

namespace HolaMundo.Menu
{
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        public void NavegarGatos(object sender, EventArgs args)
        {
            App.MenuPrincipal.Detail = new GatosPage();
            App.MenuPrincipal.IsPresented = false;
        }

        public void NavegarPerros(object sender, EventArgs args)
        {
            App.MenuPrincipal.Detail = new PerrosPage();
            App.MenuPrincipal.IsPresented = false;
        }
    }
}
