using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace HolaMundo
{
    public partial class LoginViaCodigo : ContentPage
    {
        public LoginViaCodigo()
        {
            InitializeComponent();

            StackLayout stack = new StackLayout();

            Entry entry = new Entry()
            {
                Placeholder = "Usuario"
            };

            Button boton = new Button()
            {
                Text = "Enviar"
            };

            boton.Clicked += ValidarUsuario;

            stack.Children.Add(entry);
            stack.Children.Add(boton);

            this.Content = stack;
        }

        public void ValidarUsuario(object sender, EventArgs args)
        {

        }
    }
}
