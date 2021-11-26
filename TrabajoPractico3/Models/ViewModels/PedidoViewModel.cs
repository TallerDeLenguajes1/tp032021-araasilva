using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TrabajoPractico3.Models.ViewModels
{
    public class PedidoViewModel
    {
        public int Id { get; set; }       
        public ClienteViewModel Cliente { get; set; } 

        [Display (Name ="Observacion")]
        [StringLength(200)]
        [Required(ErrorMessage = "Campo requerido")]
        public string Obs { get; set; }

        [Required(ErrorMessage = "Campo requerido")]
        public TipoDeEstados Estado { get; set; }
        public int Id_cadete { get; set; }

        public PedidoViewModel()
        {

        }
    }
}
