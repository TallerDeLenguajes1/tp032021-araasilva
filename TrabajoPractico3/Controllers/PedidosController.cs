using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TrabajoPractico3.Controllers
{
    public class PedidosController : Controller
    {
        private readonly Logger _logger;

        public PedidosController(Logger log)
        {
            _logger = log;
            _logger.Debug("NLog injected into HomeController");
        }
        public IActionResult AltaPedido()
        {
            return View();
        }
    }
}
