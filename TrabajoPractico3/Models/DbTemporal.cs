using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;
using NLog;

namespace TrabajoPractico3.Models
{
    public class DbTemporal
    {
        public Cadeteria Cadeteria { get; set; }
        private const string pathCadetes = @"Cadetes.json";
        private const string pathPedidos = @"Pedidos.json";
        private static Logger logger = LogManager.GetCurrentClassLogger();

        public DbTemporal()
        {
            Cadeteria = new Cadeteria();
            if (!File.Exists(pathCadetes))
            {
                // File.Create(path);
                using (FileStream miArchivo = new FileStream(pathCadetes, FileMode.Create))
                {
                    using (StreamWriter writer = new StreamWriter(miArchivo))
                    {
                        writer.Write("");
                        writer.Close();
                        writer.Dispose();
                    }
                }
            }else Cadeteria.Cadetes = getCadetes();

            if (!File.Exists(pathPedidos))
            {
                // File.Create(path);
                using (FileStream miArchivo = new FileStream(pathPedidos, FileMode.Create))
                {
                    using (StreamWriter writer = new StreamWriter(miArchivo))
                    {
                        writer.Write("");
                        writer.Close();
                        writer.Dispose();
                    }
                }
            }else Cadeteria.Pedidos = getPedidos();
        }

        public void guardarCadetes(List<Cadete> Cadetes)
        {
            try
            {
                string jsonString = JsonSerializer.Serialize(Cadetes);
                using (FileStream miArchivoCadetes = new FileStream(pathCadetes, FileMode.Create))
                {
                    using (StreamWriter strWriter = new StreamWriter(miArchivoCadetes))
                    {
                        strWriter.WriteLine(jsonString);
                        strWriter.Close();
                        strWriter.Dispose();
                    }
                }

            }catch(Exception ex)
            {
                logger.Error(ex.ToString());
            }
        }
        public void guardarPedidos(List<Pedido> Pedidos)
        {
            try
            {
                string jsonString = JsonSerializer.Serialize(Pedidos);
                using (FileStream miArchivoCadetes = new FileStream(pathPedidos, FileMode.Create))
                {
                    using (StreamWriter strWriter = new StreamWriter(miArchivoCadetes))
                    {
                        strWriter.WriteLine(jsonString);
                        strWriter.Close();
                        strWriter.Dispose();
                    }
                }
            }catch(Exception ex)
            {
                logger.Error(ex.ToString());
            }
        }

        public List<Cadete> getCadetes()
        {
                List<Cadete> CadetesJson = null;
                try
                {
                    using (FileStream miArchivoCadetes = new FileStream(pathCadetes, FileMode.OpenOrCreate))
                    {
                        using (StreamReader strReader = new StreamReader(miArchivoCadetes))
                        {
                            string cadetes = strReader.ReadToEnd();
                            
                            strReader.Close();
                            strReader.Dispose();
                            if (cadetes != "")
                            {
                                CadetesJson = JsonSerializer.Deserialize<List<Cadete>>(cadetes);
                            }
                            else
                            {
                                CadetesJson = new List<Cadete>();
                            }
                        }
                    }
                }
                catch(Exception ex)
                {
                    logger.Error(ex.ToString());
                }

            return CadetesJson;
        }
        public List<Pedido> getPedidos()
        {
            List<Pedido> PedidosJson = null;
            
            try
            {
                using (FileStream miArchivoCadetes = new FileStream(pathPedidos, FileMode.OpenOrCreate))
                {
                    using (StreamReader strReader = new StreamReader(miArchivoCadetes))
                    {
                        string pedidos = strReader.ReadToEnd();
                        strReader.Close();
                        strReader.Dispose();
                        if (pedidos != "")
                        {
                            PedidosJson = JsonSerializer.Deserialize<List<Pedido>>(pedidos);
                        }
                        else
                        {
                            PedidosJson = new List<Pedido>();
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                 logger.Error(ex.ToString());
            }
            
            return PedidosJson;
        }

        public void DeletePedido(int id)
        {
            //List<Cadete> CadeteJson = null;
            try
            {
                // 1- leer mis cadetes 
                List<Pedido> listaDePedidos = getPedidos();
                Pedido pedido1 = listaDePedidos.Find(x => x.Id == id);
                Cadete cadeteAModificar = buscarCadete(Cadeteria.Cadetes, pedido1.Id_cadete);
                //// 2- eliminar de la lista los cadetes buscado 
                listaDePedidos.RemoveAll(x => x.Id == id);

                List<Pedido> nuevo = listaDePedidos.ToList();

                //// 3- Guardar lista en archivo 
                guardarPedidos(nuevo);

                //// 4 - actualizar la lista de Pedidos
                Cadeteria.Pedidos = listaDePedidos;

                //// 5 - actualizar pedido en cadete
                BorrarPedidoEnCadete(cadeteAModificar.Id, id);
                
            }
            catch (Exception ex)
            {
                string error = ex.ToString();
            }
        }
        public void DeleteCadete(int id)
        {
            //List<Cadete> CadeteJson = null;
            try
            {
                // 1- leer mis cadetes 
                List<Cadete> listaDeCadetes = getCadetes();

                //// 2- eliminar de la lista los cadetes buscado 
                listaDeCadetes.RemoveAll(x => x.Id == id);

                List<Cadete> nuevo = listaDeCadetes.ToList();

                //// 3- Guardar lista en archivo 

                guardarCadetes(nuevo);

                //// 4 - actualizar la lista de cadetería 
                Cadeteria.Cadetes = listaDeCadetes;

            }
            catch (Exception ex)
            {
                string error = ex.ToString();
            }
        }

        public void ModificarCadete(int id, string nombre, string direccion, string telefono)
        {
            try
            {
                List<Cadete> listaDeCadetes = getCadetes();
                Cadete cadeteAModificar = buscarCadete(listaDeCadetes, id);
                if (cadeteAModificar != null)
                {
                    cadeteAModificar.Nombre = nombre;
                    cadeteAModificar.Direccion = direccion;
                    cadeteAModificar.Telefono = telefono;
                }

                List<Cadete> nuevo = listaDeCadetes.ToList();

                string CadeteJson1 = JsonSerializer.Serialize(nuevo);
                using (FileStream miArchivo = new FileStream(pathCadetes, FileMode.Create))
                {
                    using (StreamWriter writer = new StreamWriter(miArchivo))
                    {
                        writer.Write(CadeteJson1);
                        writer.Close();
                        writer.Dispose();
                    }
                }
                Cadeteria.Cadetes = listaDeCadetes;
            }
            catch (Exception ex)
            {
                string error = ex.ToString();
            }

        }
        public void ModificarPedido(int id, string obs, TipoDeEstados estado, string nombre, string direccion, string telefono, int id_cadete)
        {
            try
            {
                List<Pedido> listaDePedidos = getPedidos();
                Pedido pedidoAModificar = buscarPedido(Cadeteria.Pedidos, id);
                if (pedidoAModificar != null)
                {
                    pedidoAModificar.Obs = obs;
                    pedidoAModificar.Estado = estado;
                    pedidoAModificar.Cliente.Nombre = nombre;
                    pedidoAModificar.Cliente.Direccion = direccion;
                    pedidoAModificar.Cliente.Telefono = telefono;
                }
                List<Pedido> nuevo = listaDePedidos.ToList();

                string CadeteJson1 = JsonSerializer.Serialize(nuevo);
                using (FileStream miArchivo = new FileStream(pathPedidos, FileMode.Create))
                {
                    using (StreamWriter writer = new StreamWriter(miArchivo))
                    {
                        writer.Write(CadeteJson1);
                        writer.Close();
                        writer.Dispose();
                    }
                }
                Cadeteria.Pedidos = listaDePedidos;
                MofificarPedidoEnCadete(id_cadete, pedidoAModificar);
            }
            catch (Exception ex)
            {
                string error = ex.ToString();
            }

        }
        public Pedido buscarPedido(List<Pedido> listaPedidos, int id)
        {
            Pedido pedidoAdevolver = null;
            for (int i = 0; i < listaPedidos.Count(); i++)
            {
                if (listaPedidos[i].Id == id)
                {
                    pedidoAdevolver = listaPedidos[i];
                    break;
                }
            }
            return pedidoAdevolver;
        }
        public Cadete buscarCadete(List<Cadete> listaCadetes, int id)
        {
            Cadete cadeteAdevolver = null;
            for (int i = 0; i < listaCadetes.Count(); i++)
            {
                if (listaCadetes[i].Id == id)
                {
                    cadeteAdevolver = listaCadetes[i];
                    break;
                }
            }
            return cadeteAdevolver;
        }
        public void MofificarPedidoEnCadete(int id, Pedido pedido)
        {
            foreach(var cadete in Cadeteria.Cadetes)
            {
                if(cadete.Id == id)
                {
                    foreach(var item in cadete.Pedidos)
                    {
                        if(item.Id == pedido.Id)
                        {
                            item.Obs = pedido.Obs;
                            item.Estado = pedido.Estado;
                            item.Cliente = pedido.Cliente;
                            break;
                        }
                    }
                }
            }guardarCadetes(Cadeteria.Cadetes);
        }
        public void BorrarPedidoEnCadete(int id_cadete, int id_pedido)
        {
            foreach(var cadete in Cadeteria.Cadetes)
            {
                if(cadete.Id == id_cadete)
                {
                    cadete.Pedidos.RemoveAll(x => x.Id == id_pedido);
                    break;
                }
            }
            guardarCadetes(Cadeteria.Cadetes);
        }
        public bool LiquidarCadete(int id)
        {
            bool bandera = false;
            try
            {
                Cadete cadeteALiquidar = buscarCadete(Cadeteria.Cadetes, id);
                foreach(var pedido in cadeteALiquidar.Pedidos)
                {
                    if(pedido.Estado == TipoDeEstados.Entregado)
                    {
                        DeletePedido(pedido.Id);
                        bandera = true;
                    }
                }

            }catch(Exception ex)
            {
                logger.Error(ex.ToString());
                return false;
            }
            return bandera;
        }


    }
}