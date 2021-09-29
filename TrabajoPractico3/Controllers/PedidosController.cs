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
        public IActionResult AltaPedido(int id, string nombre, string direccion, long telefono, string obs, string estado, int id_cadete)
        {
            Cliente nuevoCliente = new Cliente(nombre, direccion, telefono);
            Pedido nuevoPedido = new Pedido(id, nuevoCliente, obs, estado);
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

        public IActionResult Modificar(int id)
        {
            Pedido pedidoADevolver = null;
            for (int i = 0; i<db.Cadeteria.Pedidos.Count(); i++)
            {
                if(db.Cadeteria.Pedidos[i].Id == id)
                {
                    pedidoADevolver = db.Cadeteria.Pedidos[i];
                    break;
                }
            }
            if(pedidoADevolver != null)
            {
                return View(pedidoADevolver);
            }
            return View();
        }

        public IActionResult ModificarPedido(int id, string obs, string estado, string nombre, string direccion, long telefono)
        {
            Pedido pedidoAModificar = null;
            for (int i = 0; i < db.Cadeteria.Cadetes.Count(); i++)
            {
                if (db.Cadeteria.Pedidos[i].Id == id)
                {
                    pedidoAModificar = db.Cadeteria.Pedidos[i];
                    break;
                }
            }
            if (pedidoAModificar != null)
            {
                pedidoAModificar.Obs = obs;
                pedidoAModificar.Estado = estado;
                pedidoAModificar.Cliente.Nombre = nombre;
                pedidoAModificar.Cliente.Direccion = direccion;
                pedidoAModificar.Cliente.Telefono = telefono;
            }
            db.guardarPedidos(db.Cadeteria.Pedidos);
            return View("index", db.Cadeteria.Pedidos);
        }
        public IActionResult Borrar(int id)
        {
            db.Cadeteria.Pedidos.RemoveAll(x => x.Id == id);
            db.guardarPedidos(db.Cadeteria.Pedidos);
            return View("Index", db.Cadeteria.Pedidos);
        }
    }
}
