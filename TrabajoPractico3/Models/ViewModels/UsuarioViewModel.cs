using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrabajoPractico3.Models.ViewModels
{
    public class UsuarioViewModel
    {
        [Key]
        public int Id { get; set; }

        [Display(Name ="Nombre de Usuario")]
        public string NombreDeUsuario { get; set; }

        [Required]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Contraseña")]
        public string Contrasenia { get; set; }

        public UsuarioViewModel()
        {
        }
    }
}
