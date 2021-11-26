using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using NLog;

namespace TrabajoPractico3.Models
{
 
    public class RepositorioCadeteSQLITE : IRepositorioCadete
    {

        private readonly string connectionString;
        private readonly Logger logger;
        public RepositorioCadeteSQLITE(string connectionString, Logger logger)
        {
            this.connectionString = connectionString;
            this.logger = logger;
        }

        public List<Cadete> getAll()
        {
            List<Cadete> ListaDeCadetes = new List<Cadete>();
            string SqlQuery = @"Select * from Cadetes WHERE activo = 1;";
            try{
                using(SQLiteConnection conexion = new SQLiteConnection(connectionString))
                {                
                    using(SQLiteCommand command = new SQLiteCommand(SqlQuery, conexion)){
                        conexion.Open();
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
                }    
                
            }catch(Exception ex){
                logger.Error(ex.ToString());
            }
            
            return ListaDeCadetes;
        }
        public void SaveCadete(Cadete cadete)
        {
            string SqlQuery = @"INSERT INTO Cadetes 
                                    (cadeteNombre, 
                                    cadeteDireccion, 
                                    cadeteTelefono, 
                                    activo) 
                                VALUES 
                                    (@nombre, 
                                    @direccion, 
                                    @telefono, 
                                    1);";
            try{
                using (SQLiteConnection conexion = new SQLiteConnection(connectionString))
                {
                    conexion.Open();
                    using (SQLiteCommand command = new SQLiteCommand(SqlQuery, conexion))
                    {
                        command.Parameters.AddWithValue("@nombre", cadete.Nombre);
                        command.Parameters.AddWithValue("@direccion", cadete.Direccion);
                        command.Parameters.AddWithValue("@telefono", cadete.Telefono);
                        command.ExecuteNonQuery();
                    }
                    conexion.Close();
                }
            }catch(Exception ex){
                logger.Error(ex.ToString());
            }
        }
        public void UpdateCadete(Cadete cadete)
        {
            string SqlQuery = @"UPDATE Cadetes SET cadeteNombre= @nombre, cadeteDireccion = @direccion, cadeteTelefono = @telefono, activo= 1 WHERE cadeteId = @id;";
            try{
                using (SQLiteConnection conexion = new SQLiteConnection(connectionString))
                {
                    conexion.Open();
                    using (SQLiteCommand command = new SQLiteCommand(SqlQuery, conexion))
                    {
                        command.Parameters.AddWithValue("@nombre", cadete.Nombre);
                        command.Parameters.AddWithValue("@direccion", cadete.Direccion);
                        command.Parameters.AddWithValue("@telefono", cadete.Telefono);
                        command.Parameters.AddWithValue("@id", cadete.Id);
                        command.ExecuteNonQuery();
                    }
                    conexion.Close();
                }
            }catch(Exception ex){
                logger.Error(ex.ToString());            }
            
        }

        public void Delete(int id)
        {
            string SqlQuery = "UPDATE Cadetes SET activo = 0 WHERE cadeteID = @id";
            try{
                using (SQLiteConnection conexion = new SQLiteConnection(connectionString))
                {
                    conexion.Open();
                    using (SQLiteCommand command = new SQLiteCommand(SqlQuery, conexion))
                    {

                        command.Parameters.AddWithValue("@id", id);
                        command.ExecuteNonQuery();
                    }
                    conexion.Close();
                }
            }catch(Exception ex){
                logger.Error(ex.ToString());
            }
            
        }
    }
}