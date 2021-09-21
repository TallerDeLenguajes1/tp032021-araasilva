using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp3
{
    class Cadeteria
    {
        private string nombre;
        private List<Cadete> cadetes;

        public string Nombre { get => nombre; set => nombre = value; }
        internal List<Cadete> Cadetes { get => cadetes; set => cadetes = value; }
    }
}
