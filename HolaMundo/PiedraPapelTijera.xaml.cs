using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HolaMundo
{
    public partial class PiedraPapelTijera : ContentPage
    {
        public PiedraPapelTijera()
        {
            InitializeComponent();
        }

        public void Eleccion(object sender, EventArgs args)
        {
            Button botonElegido = (Button)sender;
            int miEleccion = 0;
            int puntosComputadora = int.Parse(labelPuntosComputadora.Text);
            int misPuntos = int.Parse(labelMisPuntos.Text);

            if (botonElegido.Text == "Piedra")
            {
                miEleccion = 1;
            }
            else if (botonElegido.Text == "Papel")
            {
                miEleccion = 2;
            }
            else
            {
                miEleccion = 3;
            }

            int eleccionComputadora = new Random().Next(0, 3) + 1;

            if (eleccionComputadora == 1)
            {
                labelEleccionComputadora.Text = "Piedra";
            }
            else if (eleccionComputadora == 2)
            {
                labelEleccionComputadora.Text = "Papel";
            }
            else
            {
                labelEleccionComputadora.Text = "Tijera";
            }

            if (miEleccion == 1 && eleccionComputadora == 2)
            {
                puntosComputadora++;
                labelEleccionComputadora.TextColor = Color.Red;
            }
            else if (miEleccion == 2 && eleccionComputadora == 3)
            {
                puntosComputadora++;
                labelEleccionComputadora.TextColor = Color.Red;
            }
            else if (miEleccion == 3 && eleccionComputadora == 1)
            {
                puntosComputadora++;
                labelEleccionComputadora.TextColor = Color.Red;
            }
            else if (miEleccion == 1 && eleccionComputadora == 3)
            {
                misPuntos++;
                labelEleccionComputadora.TextColor = Color.Green;
            }
            else if (miEleccion == 2 && eleccionComputadora == 1)
            {
                misPuntos++;
                labelEleccionComputadora.TextColor = Color.Green;
            }
            else if (miEleccion == 3 && eleccionComputadora == 2)
            {
                misPuntos++;
                labelEleccionComputadora.TextColor = Color.Green;
            }
            else
            {
                labelEleccionComputadora.TextColor = Color.Blue;
            }

            labelPuntosComputadora.Text = puntosComputadora.ToString();
            labelMisPuntos.Text = misPuntos.ToString();
        }
    }
}
