using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Xamarin.Forms;

namespace HolaMundo.Views
{
    public partial class ListadoPersonajes : ContentPage
    {
        public ListadoPersonajes()
        {
            InitializeComponent();

            ObservableCollection<Personaje> personajes = new ObservableCollection<Personaje>();

            HttpClient client = new HttpClient();

            Device.InvokeOnMainThreadAsync(async () =>
            {
                string resultado = await client.GetStringAsync("https://swapi.co/api/people/1"); ;
                Personaje pers = JsonConvert.DeserializeObject<Personaje>(resultado);

                personajes.Add(pers);

                listaPersonajes.ItemsSource = personajes;
            });
        }
    }

    public class Personaje
    {
        public string name { get; set; }
    }
}
