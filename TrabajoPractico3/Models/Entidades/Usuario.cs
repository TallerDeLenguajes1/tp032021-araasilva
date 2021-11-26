using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabajoPractico3.Models.Entidades
{
    public class Usuario
    {
        private int id;
        private string nombreDeUsuario;
        private string email;
        private string contrasenia;

        public Usuario()
        {
        }

        public Usuario(string nombreDeUsuario, string email, string contrasenia)
        {
            this.NombreDeUsuario = nombreDeUsuario;
            this.Email = email;
            this.Contrasenia = contrasenia;
        }

        public int Id { get => id; set => id = value; }
        public string NombreDeUsuario { get => nombreDeUsuario; set => nombreDeUsuario = value; }
        public string Email { get => email; set => email = value; }
        public string Contrasenia { get => contrasenia; set => contrasenia = value; }
    }
}
