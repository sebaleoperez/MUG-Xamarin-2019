using System;
using System.Collections.Generic;
using System.IO;
using HolaMundo.Services;
using SQLite;
using Xamarin.Forms;

namespace HolaMundo.Views
{
    public partial class ListadoPlanetas : ContentPage
    {
        public ListadoPlanetas()
        {
            InitializeComponent();


        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();

            string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "TodoSQLite.db3");
            SQLiteAsyncConnection conn = new SQLiteAsyncConnection(dbPath);
            conn.CreateTableAsync<Planeta>().Wait();

            PlanetaService planetaService = new PlanetaService();

            List<Planeta> planetas = await planetaService.GetPlanetas();

            listadoPlanetas.ItemsSource = planetas;

            await conn.InsertAsync(planetas[0]);

            List<Planeta> planetasDB = await conn.Table<Planeta>().ToListAsync();

            await DisplayAlert("Cantidad", "Tengo " + planetasDB.Count, "OK");

            await conn.CloseAsync();
        }

        public void ClickElemento(object sender, ItemTappedEventArgs args)
        {
            Planeta planeta = (Planeta)args.Item;

            Navigation.PushAsync(new DetallePlaneta(planeta));
        }
    }
}
