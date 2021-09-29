using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico3.Models
{
    public class Cliente
    {
        private static int id = 0;
        private string nombre;
        private string direccion;
        private long telefono;

        public Cliente()
        {
        }

        public Cliente(string nombre, string direccion, long telefono)
        {
            id++;
            this.nombre = nombre;
            this.direccion = direccion;
            this.telefono = telefono;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public long Telefono { get => telefono; set => telefono = value; }
    }
}
