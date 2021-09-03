using System;

namespace Cadeteria
{
	public class Pedidos
	{
		private int numero;
		private string obs;
		private Cliente cliente;
		private string estado;

        public int Numero { get => numero; set => numero = value; }
        public string Obs { get => obs; set => obs = value; }
        public Cliente Cliente { get => cliente; set => cliente = value; }
        public string Estado { get => estado; set => estado = value; }
    }
}
	
