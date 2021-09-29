using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico3.Models
{
    public class Cadete
    {
        private int id;
        private string nombre;
        private string direccion;
        private long telefono;
        private List<Pedido> pedidos;

        public Cadete()
        {
            pedidos = new List<Pedido>();
        }

        public Cadete(int id, string nombre, string direccion, long telefono)
        {
            this.id = id;
            this.nombre = nombre;
            this.direccion = direccion;
            this.telefono = telefono;
            pedidos = new List<Pedido>();
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public long Telefono { get => telefono; set => telefono = value; }
        public List<Pedido> Pedidos { get => pedidos; set => pedidos = value; }
    }
}
