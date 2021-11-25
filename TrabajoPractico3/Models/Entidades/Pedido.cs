using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico3.Models
{
    public enum TipoDeEstados
    {
        En_camino = 0,
        Entregado = 1,
        No_entregado = 2,
        Perdido = 3
    }  
    public class Pedido
    {
        private int id;
        private Cliente cliente;
        private string obs;
        private TipoDeEstados estado;
        private int id_cadete;

        public Pedido()
        {
            cliente = new Cliente();
        }

        public Pedido(Cliente cliente, string obs, TipoDeEstados estado, int cadete)
        {
            this.cliente = cliente;
            this.obs = obs;
            this.estado = estado;
            id_cadete = cadete;
        }

        public int Id { get => id; set => id = value; }
        public string Obs { get => obs; set => obs = value; }
        public TipoDeEstados Estado { get => estado; set => estado = value; }
        public int Id_cadete { get => id_cadete; set => id_cadete = value; }
        public Cliente Cliente { get => cliente; set => cliente = value; }
    }
}
