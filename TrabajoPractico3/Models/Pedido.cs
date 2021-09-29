using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico3.Models
{
  
    public class Pedido
    {
        private int id;
        private Cliente cliente;
        private string obs;
        private string estado;

        public Pedido()
        {
            this.cliente = new Cliente();
        }

        public Pedido(int id, Cliente cliente, string obs, string estado)
        {
            this.id = id;
            this.cliente = cliente;
            this.obs = obs;
            this.estado = estado;
        }

        public int Id { get => id; set => id = value; }
        public string Obs { get => obs; set => obs = value; }
        public string Estado { get => estado; set => estado = value; }
        public Cliente Cliente { get => cliente; set => cliente = value; }
    }
}
