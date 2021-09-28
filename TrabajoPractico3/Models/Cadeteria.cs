using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico3.Models
{
    public class Cadeteria
    {
    
        private List<Cadete> cadetes;
        private List<Pedido> pedidos;
        public Cadeteria()
        {
            cadetes = new List<Cadete>();
            pedidos = new List<Pedido>();
            
        }

        public Cadeteria(List<Cadete> _Cadetes, List<Pedido> _Pedidos)
        {
            cadetes = _Cadetes;
            pedidos = _Pedidos;
        }

        public List<Cadete> Cadetes { get => cadetes; set => cadetes = value; }
        public List<Pedido> Pedidos { get => pedidos; set => pedidos = value; }
    }
}
