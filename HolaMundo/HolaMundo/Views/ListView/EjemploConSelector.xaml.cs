using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace HolaMundo.Views.ListView
{
    public partial class EjemploConSelector : ContentPage
    {
        public EjemploConSelector()
        {
            InitializeComponent();

            Jugador jugador = new Jugador();
            jugador.Nombre = "Lionel Messi";
            jugador.Posicion = "Delantero";
            jugador.Url = "https://as01.epimg.net/img/comunes/fotos/fichas/deportistas/m/mes/large/15167.png";

            Jugador otroJugador = new Jugador();
            otroJugador.Nombre = "Sergio Aguero";
            otroJugador.Posicion = "Delantero";
            otroJugador.Url = "https://static.classora-technologies.com/files/uploads/images/entries/515146/main.jpg";

            Jugador otroJugadorMas = new Jugador();
            otroJugadorMas.Nombre = "Pipita Higuain";
            otroJugadorMas.Posicion = "Arquero";
            otroJugadorMas.Url = "gato.jpg";

            ObservableCollection<Jugador> listado = new ObservableCollection<Jugador>();
            listado.Add(jugador);
            listado.Add(otroJugador);
            listado.Add(otroJugadorMas);

            ListViewPrincipal.ItemsSource = listado;
        }

        public void ClickearElemento(object sender, ItemTappedEventArgs args)
        {
            Navigation.PushAsync(new MostradorGigante(args.Item.ToString()));

        }
    }
}
