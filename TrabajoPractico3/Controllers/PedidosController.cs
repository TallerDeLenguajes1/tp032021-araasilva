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
        private readonly IRepositorioPedido RepoPedido;
        private readonly IRepositorioCadete RepoCadete;


        public PedidosController(Logger log, IRepositorioPedido RepoPedido, IRepositorioCadete RepoCadete)
        {
            _logger = log;
            _logger.Debug("NLog injected into HomeController");
            this.RepoPedido = RepoPedido;
            this.RepoCadete = RepoCadete;
        }
         public IActionResult Index()
        {
            return View(RepoPedido.getAll());
        }
        public IActionResult CreatePedido()
        {
            return View(RepoCadete.getAll());
        }
        public IActionResult AltaPedido(string nombre, string direccion, string telefono, string obs, TipoDeEstados estado, int id_cadete)
        {
            
            Cliente nuevoCliente = new Cliente(nombre, direccion, telefono);
            Pedido nuevoPedido = new Pedido(nuevoCliente, obs, estado, id_cadete);
            RepoPedido.SavePedido(nuevoPedido);
            return View("index", RepoPedido.getAll());
        }

        public IActionResult Modificar(int id)
        {
            List<Pedido> pedidos = RepoPedido.getAll();
            Pedido pedidoADevolver = pedidos.Find(x => x.Id == id);
            if(pedidoADevolver != null)
            {
                return View(pedidoADevolver);
            }
            return View();
        }

        public IActionResult ModificarPedido(int id, string obs, TipoDeEstados estado, string nombre, string direccion, string telefono)
        {
            List<Pedido> pedidos = RepoPedido.getAll();
            Pedido pedidoAModificar = pedidos.Find(x => x.Id == id);
            if (pedidoAModificar != null)
            {
                pedidoAModificar.Obs = obs;
                pedidoAModificar.Estado = estado;
                pedidoAModificar.Cliente.Nombre = nombre;
                pedidoAModificar.Cliente.Direccion = direccion;
                pedidoAModificar.Cliente.Telefono = telefono;
            }

            RepoPedido.UpdatePedido(pedidoAModificar);
            return View("index", RepoPedido.getAll());
        }
        public IActionResult Borrar(int id)
        {
            RepoPedido.Delete(id);
            return View("Index", RepoPedido.getAll());
        }
    }
}
