using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HolaMundo
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        public void ValidarUsuario(object sender, EventArgs args)
        {
            if (EntryUsuario.Text == "usuario" && EntryClave.Text == "12345")
            {
                DisplayAlert("Validacion", "Ok !", "OK");
            }
            else
            {
                DisplayAlert("Validacion", "ERROR !", "OK");
            }
        }
    }
}
