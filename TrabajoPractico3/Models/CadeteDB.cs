using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace TrabajoPractico3.Models
{
    public class RepositorioCadete
    {
        private readonly string connectionString;
       //private readonly SQLiteConnection conexion;
        public RepositorioCadete(string connectionString){
            this.connectionString = connectionString;
            //conexion = new SQLiteConnection(connectionString);
        }
        
        public List<Cadete> getAll(){
            List<Cadete> ListaDeCadetes = new List<Cadete>();
            using(SQLiteConnection conexion = new SQLiteConnection(connectionString)){
                conexion.Open();
                string SqlQuery = "Select * from Cadetes;";
                SQLiteCommand command = new SQLiteCommand(SqlQuery, conexion);
                SQLiteDataReader DataReader = command.ExecuteReader();
                while (DataReader.Read())
                {
                    
                    Cadete cadete = new Cadete()
                    {
                        Id = Convert.ToInt32(DataReader["cadeteID"]),
                        Nombre = DataReader["cadeteNombre"].ToString(),
                        Direccion = DataReader["cadeteDireccion"].ToString(),
                        Telefono = DataReader["cadeteTelefono"].ToString(),
                    };
                    ListaDeCadetes.Add(cadete);
                }
                conexion.Close();
            }
            return ListaDeCadetes;
        }
    }
}