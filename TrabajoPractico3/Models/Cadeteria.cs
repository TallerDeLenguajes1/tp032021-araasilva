using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico3.Models
{
    public class Cadeteria
    {
        private string nombre;
        private List<Cadete> cadetes;
        private List<Pedido> pedidos;
        public Cadeteria()
        {
            
        }

        public Cadeteria(string nombre)
        {
            this.nombre = nombre;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        internal List<Cadete> Cadetes { get => cadetes; set => cadetes = value; }
        internal List<Pedido> Pedidos { get => pedidos; set => pedidos = value; }
    }
}
