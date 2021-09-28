using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabajoPractico3.Models
{
    public class DbTemporal
    {
        public Cadeteria Cadeteria { get; set; }

        public DbTemporal()
        {
            Cadeteria = new Cadeteria();
        }

    }
}
