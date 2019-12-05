using System;
using System.ComponentModel;
using System.Windows.Input;
using HolaMundo.Services;
using Xamarin.Forms;

namespace HolaMundo.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        public string Usuario { get; set; }
        public string Clave { get; set; }

        public string ResultadoLogin { get; set; }

        public ICommand EventoClick { get; set; }


        public LoginViewModel()
        {
            EventoClick = new Command(ValidarUsuario);
        }

        private void ValidarUsuario()
        {
            LoginService loginService = new LoginService();
            if (loginService.ValidarUsuario(this.Usuario,this.Clave))
            {
                this.ResultadoLogin = "USUARIO VALIDO";
            }
            else
            {
                this.ResultadoLogin = "USUARIO NO VALIDO";
            }
            OnPropertyChanged("ResultadoLogin");

            NavigationService navigationService = new NavigationService();
            navigationService.AccionLoginValido();
        }
    }
}
