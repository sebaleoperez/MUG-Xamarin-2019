using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HolaMundo
{
    public partial class ListadoNumeros : ContentPage
    {
        public ListadoNumeros()
        {
            InitializeComponent();
        }

        public void CrearLabels(object sender, EventArgs args)
        {
            StackLayoutListadoNumeros.Children.Clear();

            int cantidad = 0;
            bool resultado = int.TryParse(EntryCantidad.Text, out cantidad);

            if (resultado)
            {
                for (int iterador = 0; iterador < cantidad; iterador++)
                {
                    Label label = new Label()
                    {
                        Text = iterador.ToString()
                    };
                    StackLayoutListadoNumeros.Children.Add(label);
                }
            }
            else
            {
                DisplayAlert("Error", "El texto ingresado no es un numero", "OK");
            }
        }
    }
}
