using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrabajoPractico3.Models;
using TrabajoPractico3.Models.ViewModels;

namespace TrabajoPractico3.Controllers
{
    public class PedidosController : Controller
    {
        private readonly IRepositorioPedido RepoPedido;
        private readonly IRepositorioCadete RepoCadete;
        private readonly IMapper mapper;
        private readonly Logger _logger;

        public PedidosController(IRepositorioPedido RepoPedido, IRepositorioCadete RepoCadete, IMapper mapper, Logger _logger)
        {
            this._logger = _logger;
            this.RepoPedido = RepoPedido;
            this.RepoCadete = RepoCadete;
            this.mapper = mapper;
        }
         public IActionResult Index()
        {
            var pedidos = mapper.Map<List<PedidoViewModel>>(RepoPedido.getAll());
            return View(pedidos);
        }
        public IActionResult CreatePedido()
        {
            var cadetes = mapper.Map<List<CadeteViewModel>>(RepoCadete.getAll());
            return View(cadetes); 
        }
        public IActionResult AltaPedido(string nombre, string direccion, string telefono, string obs, TipoDeEstados estado, int id_cadete)
        {
            if (obs != null && direccion!=null && nombre!= null && telefono!= null)
            {
                Cliente nuevoCliente = new Cliente(nombre, direccion, telefono);
                Pedido nuevoPedido = new Pedido(nuevoCliente, obs, estado, id_cadete);
                RepoPedido.SavePedido(nuevoPedido);
            }
            var pedidos = mapper.Map<List<PedidoViewModel>>(RepoPedido.getAll());
            return View("index", pedidos);
        }

        public IActionResult Modificar(int id)
        {
            List<Pedido> pedidos = RepoPedido.getAll();
            Pedido pedidoADevolver = pedidos.Find(x => x.Id == id);
            if(pedidoADevolver != null)
            {
                var pedido = mapper.Map<PedidoViewModel>(pedidoADevolver);
                return View(pedido);
            }
            return View();
        }
        
        public IActionResult ModificarPedido(int id, string obs, TipoDeEstados estado, string nombre, string direccion, string telefono)
        {
            List<Pedido> pedidos1 = RepoPedido.getAll();
            Pedido pedidoAModificar = pedidos1.Find(x => x.Id == id);
            if (pedidoAModificar != null)
            {
                pedidoAModificar.Obs = obs;
                pedidoAModificar.Estado = estado;
                pedidoAModificar.Cliente.Nombre = nombre;
                pedidoAModificar.Cliente.Direccion = direccion;
                pedidoAModificar.Cliente.Telefono = telefono;
            }

            RepoPedido.UpdatePedido(pedidoAModificar);
            var pedidos = mapper.Map<List<PedidoViewModel>>(RepoPedido.getAll());
            return View("index", pedidos);
        }
        public IActionResult Borrar(int id)
        {
            RepoPedido.Delete(id);
            var pedidos = mapper.Map<List<PedidoViewModel>>(RepoPedido.getAll());
            return View("Index", pedidos);
        }
    }
}
