using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HolaMundo
{
    public partial class Gris : ContentPage
    {
        public Gris()
        {
            InitializeComponent();
        }

        public async void IrANegro(object sender, EventArgs args)
        {
            await this.Navigation.PushAsync(new Negro());
        }

        protected override bool OnBackButtonPressed()
        {
            return true;
        }
    }
}
