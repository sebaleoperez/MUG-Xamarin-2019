using System;
using System.Collections.Generic;
using HolaMundo.Models;
using System.Linq;

namespace HolaMundo.Services
{
    public class LoginService
    {
        public bool ValidarUsuario(string usuario, string password)
        {
            // Acá se debería invocar a algún API o DB
            if (ObtenerUsuarios().Where(x => x.Username == usuario && x.Password == password).FirstOrDefault() != null)
            {
                return true;
            }

            return false;
        }

        public List<Usuario> ObtenerUsuarios()
        {
            // Nosotros usamos una lista de usuarios a los que consultar
            List<Usuario> usuarios = new List<Usuario>();
            usuarios.Add(new Usuario()
            {
                Username = "admin",
                Password = "12345"
            });

            return usuarios;
        }
    }
}
