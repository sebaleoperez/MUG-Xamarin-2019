using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HolaMundo
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public void ValidarUsuario(object sender, EventArgs args)
        {
            if (EntryUsuario.Text == "usuario" &&
                EntryClave.Text == "12345")
			{
				DisplayAlert("Validacion","Usuario Correcto","OK");
			}
            else
			{
				DisplayAlert("Validacion", "ERROR !", "OK");
			}
        }
    }
}
