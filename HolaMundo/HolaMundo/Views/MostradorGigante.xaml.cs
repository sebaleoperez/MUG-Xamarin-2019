using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HolaMundo.Views
{
    public partial class MostradorGigante : ContentPage
    {
        public MostradorGigante(string muestra)
        {
            InitializeComponent();
            labelGigante.Text = muestra;
        }
    }
}
