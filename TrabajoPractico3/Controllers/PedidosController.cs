using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrabajoPractico3.Models;

namespace TrabajoPractico3.Controllers
{
    public class PedidosController : Controller
    {
        private readonly Logger _logger;
        private readonly DbTemporal db;
        

        public PedidosController(Logger log, DbTemporal DB)
        {
            _logger = log;
            _logger.Debug("NLog injected into HomeController");
            db = DB;
        }
         public IActionResult Index()
        {
            return View(db.Cadeteria.Pedidos);
        }
        public IActionResult CreatePedido()
        {
            return View(db.Cadeteria.Cadetes);
        }
        public IActionResult AltaPedido(int numero, string nombre, string direccion, int telefono, string obs, string estado, int id_cadete)
        {
            Cliente nuevoCliente = new Cliente(nombre, direccion, telefono);
            Pedido nuevoPedido = new Pedido(numero, nuevoCliente, obs, estado);
            foreach(var item in db.Cadeteria.Cadetes)
            {
                if(item.Id == id_cadete)
                {
                    item.Pedidos.Add(nuevoPedido);
                }
            }
            db.Cadeteria.Pedidos.Add(nuevoPedido);
            db.guardarPedidos(db.Cadeteria.Pedidos);
            db.guardarCadetes(db.Cadeteria.Cadetes);
            return View("index", db.Cadeteria.Pedidos);
        }
        public IActionResult Borrar(int id)
        {
            db.Cadeteria.Pedidos.RemoveAll(x => x.Numero == id);
            return View("Index", db.Cadeteria.Pedidos);
        }
    }
}
