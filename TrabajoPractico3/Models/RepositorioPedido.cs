using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.SQLite;
using NLog;

namespace TrabajoPractico3.Models
{
    public class RepositorioPedidoSQLite : IRepositorioPedido
    {
        private readonly string connectionString;
        private readonly Logger logger;
        public RepositorioPedidoSQLite(string connection, Logger logger)
        {
            connectionString = connection;
            this.logger = logger;
        }

        public List<Pedido> getAll()
        {
            List<Pedido> ListaDePedidos = new List<Pedido>();
            string SqlQuery =   @"SELECT * FROM Pedidos 
                                INNER JOIN Clientes USING(clienteId) 
                                WHERE Pedidos.activo = 1 AND Clientes.activo = 1;";
            //string consulta2 = "Select * from clientes WHERE clienteId = @idcliente";
            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(connectionString))
                {
                    using (SQLiteCommand command = new SQLiteCommand(SqlQuery, conexion))
                    {
                        conexion.Open();
                        using (SQLiteDataReader DataReader = command.ExecuteReader())
                        {
                            while (DataReader.Read())
                            {
                                Cliente nuevo = new Cliente()
                                {
                                    Id = Convert.ToInt32(DataReader["clienteId"]),
                                    Nombre = DataReader["clienteNombre"].ToString(),
                                    Direccion = DataReader["clienteDireccion"].ToString(),
                                    Telefono = DataReader["clienteTelefono"].ToString()
                                };
                                Pedido pedido = new Pedido()
                                {
                                    Id = Convert.ToInt32(DataReader["pedidoId"]),
                                    Obs = DataReader["pedidoObs"].ToString(),
                                    Estado = DevuelveEstado(DataReader["pedidoEstado"].ToString()),
                                    Id_cadete = Convert.ToInt32(DataReader["cadeteId"]),
                                    Cliente = nuevo
                                };
                                ListaDePedidos.Add(pedido);
                            }
                        }
                        conexion.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Error (ex.ToString());
            }

            return ListaDePedidos;
        }
        public void SavePedido(Pedido pedido)
        {
            SaveCliente(pedido.Cliente);
            string SqlQuery = @"INSERT INTO Pedidos (pedidoObs, pedidoEstado, cadeteId, clienteId, activo) 
                                VALUES (@obs, @estado, @cadeteid, @clienteId, 1);";
            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(connectionString))
                {
                    conexion.Open();
                    using (SQLiteCommand command = new SQLiteCommand(SqlQuery, conexion))
                    {
                        command.Parameters.AddWithValue("@obs", pedido.Obs);
                        command.Parameters.AddWithValue("@estado", pedido.Estado.ToString());
                        command.Parameters.AddWithValue("@cadeteId", pedido.Id_cadete);
                        command.Parameters.AddWithValue("@clienteId", pedido.Cliente.Id);
                        command.ExecuteNonQuery();
                    }
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex.ToString());
            }
        }
        private void SaveCliente(Cliente nuevoCliente)
        {
            string SqlQuery = @"INSERT INTO Clientes (clienteNombre, clienteDireccion, clienteTelefono, activo) 
                                VALUES (@nombre, @direc, @telefono, 1);";
            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(connectionString))
                {
                    conexion.Open();
                    using (SQLiteCommand command = new SQLiteCommand(SqlQuery, conexion))
                    {
                        command.Parameters.AddWithValue("@nombre", nuevoCliente.Nombre);
                        command.Parameters.AddWithValue("@direc", nuevoCliente.Direccion);
                        command.Parameters.AddWithValue("@telefono", nuevoCliente.Telefono);
                        command.ExecuteNonQuery();
                    }
                    conexion.Close();
                }
            }
            catch(Exception ex)
            {
                logger.Error(ex.ToString());
            }
        }
        public void UpdatePedido(Pedido pedido)
        {
            UpdateCliente(pedido.Cliente);
            string SqlQuery = @"UPDATE Pedidos SET pedidoObs= @obs, pedidoEstado = @estado, cadeteId = @cadeteId, clienteId= @clienteId, activo= 1 WHERE pedidoID = @id;";
            try
            {
                using (SQLiteConnection conexion = new SQLiteConnection(connectionString))
                {
                    conexion.Open();
                    using (SQLiteCommand command = new SQLiteCommand(SqlQuery, conexion))
                    {
                        command.Parameters.AddWithValue("@obs", pedido.Obs);
                        command.Parameters.AddWithValue("@estado", pedido.Estado.ToString());
                        command.Parameters.AddWithValue("@cadeteId", pedido.Id_cadete);
                        command.Parameters.AddWithValue("@clienteId", pedido.Cliente.Id);
                        command.Parameters.AddWithValue("@Id", pedido.Id);
                        command.ExecuteNonQuery();
                    }
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                logger.Error(ex.ToString());
            }
        }
        private void UpdateCliente(Cliente cliente)
        {
            string SqlQuery = @"UPDATE Clientes SET clienteNombre=@nombre, clienteDireccion = @direc, clienteTelefono = @tel, activo = 1 WHERE clienteId = @id;";
            try
            {
                using(SQLiteConnection conexion = new SQLiteConnection(connectionString))
                {
                    conexion.Open();
                    using (SQLiteCommand command = new SQLiteCommand(SqlQuery, conexion))
                    {
                        command.Parameters.AddWithValue("@nombre", cliente.Nombre);
                        command.Parameters.AddWithValue("@direc", cliente.Direccion);
                        command.Parameters.AddWithValue("@tel", cliente.Telefono);
                        command.Parameters.AddWithValue("@id", cliente.Id);
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                string log = ex.Message;
            }

        }
        public void Delete(int id)
        {
            string SqlQuery = "UPDATE Pedidos SET activo = 0 WHERE pedidoID = @id";
            try
            {
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
            }
            catch (Exception ex)
            {
                logger.Error(ex.ToString());
            }

        }
        private TipoDeEstados DevuelveEstado(string estado)
        {
            switch (estado)
            {
                case "Entregado": return TipoDeEstados.Entregado;
                case "En_camino": return TipoDeEstados.En_camino;
                case "No_entregado": return TipoDeEstados.No_entregado;
                default: return TipoDeEstados.Perdido;
            }
        }
    }
}
