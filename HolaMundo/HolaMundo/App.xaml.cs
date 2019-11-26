using System;
using HolaMundo.Menu;
using HolaMundo.Views;
using HolaMundo.Views.ListView;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace HolaMundo
{
    public partial class App : Application
    {
        public static MasterDetailPage MenuPrincipal;
        public static int CantidadPaginas;

        public App()
        {
            InitializeComponent();

            /*
            MenuPrincipal = new MasterDetailPage()
            {
                Master = new MenuPage(),
                Detail = new NumerosConTabs()
            };

            MainPage = MenuPrincipal;
            */

            MainPage = new NavigationPage(new ListadoPersonajes());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
