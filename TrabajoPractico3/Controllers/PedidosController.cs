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
        public IActionResult AltaPedido(int numero, string nombre, string direccion, int telefono, string obs, string estado)
        {
            
            Cliente nuevoCliente = new Cliente(nombre, direccion, telefono);
            Pedido nuevoPedido = new Pedido(numero, nuevoCliente, obs, estado);
            //db.Cadeteria.Cadetes[id_cadete].Pedidos.Add(nuevoPedido);
            db.Cadeteria.Pedidos.Add(nuevoPedido);
            return View("index", db.Cadeteria);
        }

        public IActionResult Borrar(int id)
        {

            return View("Index", db.Cadeteria.Pedidos);
        }
    }
}
