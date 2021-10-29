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
        private readonly RepositorioCadete RepoCadete;
        public CadetesController(Logger log, DbTemporal DB, RepositorioCadete RepoCadete)
        {
            _logger = log;
            _logger.Debug("NLog injected into HomeController");
            db = DB;
            this.RepoCadete = RepoCadete;
        }

        public IActionResult Index()
        {
            List<Cadete> cadetes = RepoCadete.getAll();
            return View(cadetes);
        }

        public IActionResult CreateCadete()
        {
            return View();
        }
        public IActionResult AltaCadete(int id, string nombre, string direccion, string telefono)
        {
            Cadete nuevoCadete = new Cadete(id, nombre, direccion, telefono);
            db.Cadeteria.Cadetes.Add(nuevoCadete);
            db.guardarCadetes(db.Cadeteria.Cadetes);
            return View("Index", db.Cadeteria.Cadetes);
            /*Cadete nuevoCadete = new Cadete(id,nombre, direccion, telefono);
            db.guardarCadete(nuevoCadete);
            return View("Index",db.Cadeteria.Cadetes);*/
        }

        public IActionResult Modificar(int id)
        {
            Cadete cadeteADevolver = db.buscarCadete(db.Cadeteria.Cadetes, id);
            
            if (cadeteADevolver != null)
                return View(cadeteADevolver);
            else
                return View("Index");
        }
        public IActionResult ModificarCadete(int id, string nombre, string direccion, string telefono)
        {
            db.ModificarCadete(id, nombre, direccion, telefono);
            return View("Index", db.Cadeteria.Cadetes);
        }

        public IActionResult Liquidar(int id)
        {
            Cadete cadeteALiquidar = db.buscarCadete(db.Cadeteria.Cadetes, id);
 
            if(cadeteALiquidar != null)
            {
                return View(cadeteALiquidar);
            }
            return View("Index");
        }

        public IActionResult LiquidarCadete(int id)
        {
            if (db.LiquidarCadete(id))
            {
                return View("Index");
            }
            else
            {
                return View("Error");
            }
        }
            

        public IActionResult Borrar(int id)
        {
            db.DeleteCadete(id);
            return View("Index", db.Cadeteria.Cadetes);
        }
    }
}
