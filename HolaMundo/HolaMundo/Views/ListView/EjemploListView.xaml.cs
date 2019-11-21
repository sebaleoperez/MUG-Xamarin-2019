using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace HolaMundo.Views.ListView
{
    public partial class EjemploListView : ContentPage
    {
        public EjemploListView()
        {
            InitializeComponent();

            ModeloPrueba modelo = new ModeloPrueba();
            modelo.Nombre = "Juan";
            modelo.Apellido = "Perez";

            ObservableCollection<ModeloPrueba> listado = new ObservableCollection<ModeloPrueba>();
            listado.Add(modelo);

            ListViewPrincipal.ItemsSource = listado;

        }

        public void ClickearElemento(object sender, ItemTappedEventArgs args)
        {
            Navigation.PushAsync(new MostradorGigante(args.Item.ToString()));

        }
    }

    public class ModeloPrueba
    {
        public string Nombre { get; set;  }
        public string Apellido { get; set; }
    }
}
