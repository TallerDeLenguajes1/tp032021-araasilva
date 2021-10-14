using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoPractico3.Models
{
    public enum TipoDeEstados
    {
        En_camino,
        Entregado,
        No_Entregado,
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
            this.cliente = new Cliente();
        }

        public Pedido(int id, Cliente cliente, string obs, TipoDeEstados estado, int cadete)
        {
            this.id = id;
            this.cliente = cliente;
            this.obs = obs;
            this.estado = estado;
            this.id_cadete = cadete;
        }

        public int Id { get => id; set => id = value; }
        public string Obs { get => obs; set => obs = value; }
        public TipoDeEstados Estado { get => estado; set => estado = value; }
        public Cliente Cliente { get => cliente; set => cliente = value; }
        public int Id_cadete { get => id_cadete; set => id_cadete = value; }
    }
}
