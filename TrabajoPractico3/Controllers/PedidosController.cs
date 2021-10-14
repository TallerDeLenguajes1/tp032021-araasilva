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
        public IActionResult AltaPedido(string nombre, string direccion, string telefono, string obs, TipoDeEstados estado, int id_cadete)
        {
            int id = db.Cadeteria.Pedidos.Count() + 1;
            Cliente nuevoCliente = new Cliente(nombre, direccion, telefono);
            Pedido nuevoPedido = new Pedido(id, nuevoCliente, obs, estado, id_cadete);
            //Cadete aCadete = db.buscarCadete(db.Cadeteria.Cadetes, id_cadete);
            //aCadete.Pedidos.a
            foreach(var item in db.Cadeteria.Cadetes)
            {
                if(item.Id == id_cadete)
                {
                    item.Pedidos.Add(nuevoPedido);
                }
            }
            //db.guardarPedido(nuevoPedido);
            //db.guardarCadete(db.Cadeteria.Cadetes);
            db.Cadeteria.Pedidos.Add(nuevoPedido);
            db.guardarPedidos(db.Cadeteria.Pedidos);
            db.guardarCadetes(db.Cadeteria.Cadetes);
            return View("index", db.Cadeteria.Pedidos);
        }

        public IActionResult Modificar(int id)
        {
            Pedido pedidoADevolver = db.buscarPedido(db.Cadeteria.Pedidos, id);
            if(pedidoADevolver != null)
            {
                return View(pedidoADevolver);
            }
            return View();
        }

        public IActionResult ModificarPedido(int id, string obs, TipoDeEstados estado, string nombre, string direccion, string telefono, int id_cadete)
        {
            Pedido pedidoAModificar = db.buscarPedido(db.Cadeteria.Pedidos, id);
            Cadete actualizarCadete = db.buscarCadete(db.Cadeteria.Cadetes, id_cadete);
          
            if (pedidoAModificar != null)
            {
                pedidoAModificar.Obs = obs;
                pedidoAModificar.Estado = estado;
                pedidoAModificar.Cliente.Nombre = nombre;
                pedidoAModificar.Cliente.Direccion = direccion;
                pedidoAModificar.Cliente.Telefono = telefono;
            }

            Pedido pedidoCadete = db.buscarPedido(actualizarCadete.Pedidos, id);
            pedidoCadete = pedidoAModificar;

            db.guardarPedidos(db.Cadeteria.Pedidos);
            db.guardarCadetes(db.Cadeteria.Cadetes);
            return View("index", db.Cadeteria.Pedidos);
        }
        public IActionResult Borrar(int id)
        {
            db.DeletePedido(id);
            return View("Index", db.Cadeteria.Pedidos);
        }
    }
}
