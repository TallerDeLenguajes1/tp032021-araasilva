using System;

namespace Cadeteria
{
    public class Cliente
    {
	    private int id;
	    private string nombre;
	    private string direccion;
	    private long telefono;

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public long Telefono { get => telefono; set => telefono = value; }  
    }

}
