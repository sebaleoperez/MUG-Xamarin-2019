using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HolaMundo
{
    public partial class InicioStack : ContentPage
    {
        public InicioStack()
        {
            InitializeComponent();
        }

        public async void Avanzar(object sender, EventArgs args)
        {
            await this.Navigation.PushAsync(new SegundaStack());
        }
    }
}
