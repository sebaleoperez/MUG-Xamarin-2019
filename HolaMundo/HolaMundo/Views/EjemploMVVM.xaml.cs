using System;
using System.Collections.Generic;
using HolaMundo.ViewModels;
using Xamarin.Forms;

namespace HolaMundo.Views
{
    public partial class EjemploMVVM : ContentPage
    {
        public EjemploMVVM()
        {
            InitializeComponent();
        }

        public async void AplicarFiltro(object sender, EventArgs args)
        {
            //await ((JugadorViewModel)this.BindingContext).Filtrar();
        }
    }
}
