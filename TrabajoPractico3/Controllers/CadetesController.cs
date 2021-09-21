using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TrabajoPractico3.Models;
using NLog.Web;
using NLog;

namespace TrabajoPractico3.Controllers
{
    public class CadetesController : Controller
    {
        private readonly Logger _logger;

        public CadetesController(ILogger<CadetesController> logger, Logger log)
        {
            _logger = log;
            _logger.Debug("NLog injected into HomeController");
        }

        public IActionResult AltaCadete()
        {
            return View();
        }
    }
}
