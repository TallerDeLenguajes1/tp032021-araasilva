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
        private readonly DbTemporal db;
        public CadetesController(Logger log, DbTemporal DB)
        {
            _logger = log;
            _logger.Debug("NLog injected into HomeController");
            db = DB;
        }

        public IActionResult Index()
        {
            return View(db.Cadeteria.Cadetes);
        }

        public IActionResult CreateCadete()
        {
            return View();
        }
        public IActionResult AltaCadete(int id, string nombre, string direccion, int telefono)
        {
            Cadete nuevoCadete = new Cadete(id,nombre, direccion, telefono);
            db.Cadeteria.Cadetes.Add(nuevoCadete);
            return View("Index",db.Cadeteria.Cadetes);
        }

        public IActionResult Borrar(int id)
        {
            db.Cadeteria.Cadetes.RemoveAll(x => x.Id == id);
            return View("Index", db.Cadeteria.Cadetes);
        }
    }
}
