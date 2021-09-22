using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico3.Models
{
  
    public class Pedido
    {
        private int numero;
        private Cliente cliente;
        private string obs;
        private string estado;

        public Pedido()
        {
            this.Cliente = new Cliente();
        }

        public Pedido(int numero, Cliente cliente, string obs, string estado)
        {
            this.numero = numero;
            this.cliente = cliente;
            this.obs = obs;
            this.estado = estado;
        }

        public int Numero { get => numero; set => numero = value; }
        public string Obs { get => obs; set => obs = value; }
        public string Estado { get => estado; set => estado = value; }
        internal Cliente Cliente { get => cliente; set => cliente = value; }
    }
}
