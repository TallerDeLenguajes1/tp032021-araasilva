using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace TrabajoPractico3.Models
{
    public class DbTemporal
    {
        public Cadeteria Cadeteria { get; set; }
        private const string pathCadetes = @"Cadetes.json";
        private const string pathPedidos = @"Pedidos.json";

        public DbTemporal()
        {
            Cadeteria = new Cadeteria();
        }

        public void guardarCadetes(List<Cadete> Cadetes)
        {
            string jsonString = JsonSerializer.Serialize(Cadetes);
            using(FileStream miArchivoCadetes = new FileStream(pathCadetes, FileMode.OpenOrCreate))
            {
                using(StreamWriter strReader = new StreamWriter(miArchivoCadetes))
                {
                    strReader.WriteLine(jsonString);
                }
            }
        }
        public void guardarPedidos(List<Pedido> Pedidos)
        {
            string jsonString = JsonSerializer.Serialize(Pedidos);
            using (FileStream miArchivoCadetes = new FileStream(pathPedidos, FileMode.OpenOrCreate))
            {
                using (StreamWriter strReader = new StreamWriter(miArchivoCadetes))
                {
                    strReader.WriteLine(jsonString);
                }
            }
        }

        public List<Cadete> getCadetes()
        {
            List<Cadete> CadetesJson = new List<Cadete>();
            if (File.Exists(pathCadetes))
            {
                try
                {
                    using (FileStream miArchivoCadetes = new FileStream(pathCadetes, FileMode.OpenOrCreate))
                    {
                        using(StreamReader strReader = new StreamReader(miArchivoCadetes))
                        {
                            string cadetes = strReader.ReadToEnd();
                            CadetesJson = JsonSerializer.Deserialize<List<Cadete>>(cadetes);
                            strReader.Close();
                            strReader.Dispose();
                        }
                    }
                }catch
                {
                    return CadetesJson;
                }
                
            }
            return CadetesJson;
        }
        public List<Pedido> getPedidos()
        {
            List<Pedido> CadetesJson = new List<Pedido>();
            if (File.Exists(pathPedidos))
            {
                using (FileStream miArchivoCadetes = new FileStream(pathPedidos, FileMode.OpenOrCreate))
                {
                    using (StreamReader strReader = new StreamReader(miArchivoCadetes))
                    {
                        string pedidos = strReader.ReadToEnd();
                        CadetesJson = JsonSerializer.Deserialize<List<Pedido>>(pedidos);
                        strReader.Close();
                        strReader.Dispose();
                    }
                }
            }
            return CadetesJson;
        }

    }
}
