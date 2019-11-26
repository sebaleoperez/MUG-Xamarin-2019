using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace HolaMundo.Views
{
    public partial class VentanaChat : ContentPage
    {
        public VentanaChat()
        {
            InitializeComponent();

            ObservableCollection<Mensaje> mensajes = new ObservableCollection<Mensaje>();

            mensajes.Add(new Mensaje()
            {
                Contenido = "Hola",
                Entrante = true
            });

            mensajes.Add(new Mensaje()
            {
                Contenido = "Hola, como estas ?",
                Entrante = false
            });

            mensajes.Add(new Mensaje()
            {
                Contenido = "Todo bien y vos ?",
                Entrante = true
            });

            mensajes.Add(new Mensaje()
            {
                Contenido = "Todo bien",
                Entrante = false
            });

            ListadoMensajes.ItemsSource = mensajes;
        }
    }

    public class Mensaje
    {
        public string Contenido { get; set; }
        public bool Entrante { get; set; }
    }
}
