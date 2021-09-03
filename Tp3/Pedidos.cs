using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp3
{
    class Pedidos
    {
        private int numero;
        private Cliente cliente;
        private string obs;
        private string estado;

        public int Numero { get => numero; set => numero = value; }
        public string Obs { get => obs; set => obs = value; }
        public string Estado { get => estado; set => estado = value; }
        internal Cliente Cliente { get => cliente; set => cliente = value; }
    }
}
