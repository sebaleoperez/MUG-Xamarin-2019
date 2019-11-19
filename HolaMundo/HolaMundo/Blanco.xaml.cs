using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HolaMundo
{
    public partial class Blanco : ContentPage
    {
        public Blanco()
        {
            InitializeComponent();
        }

        public async void IrAGris(object sender, EventArgs args)
        {
            await this.Navigation.PushAsync(new Gris());
        }
    }
}
