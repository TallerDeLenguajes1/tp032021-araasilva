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
            db.guardarCadetes(db.Cadeteria.Cadetes);
            return View("Index",db.Cadeteria.Cadetes);
        }

        public IActionResult Modificar(int id)
        {
            Cadete cadeteADevolver = null;
            for (int i = 0; i < db.Cadeteria.Cadetes.Count(); i++)
            {
                if (db.Cadeteria.Cadetes[i].Id == id)
                {
                    cadeteADevolver = db.Cadeteria.Cadetes[i];
                    break;
                }
            }
            if (cadeteADevolver != null)
                return View(cadeteADevolver);
            else
                return View("Index");
        }
        public IActionResult ModificarCadete(int id, string nombre, string direccion, int telefono)
        {
            Cadete cadeteAModificar = null;
            for (int i = 0; i < db.Cadeteria.Cadetes.Count(); i++)
            {
                if (db.Cadeteria.Cadetes[i].Id == id)
                {
                    cadeteAModificar = db.Cadeteria.Cadetes[i];
                    break;
                }
            }
            if (cadeteAModificar != null)
            {
                cadeteAModificar.Nombre = nombre;
                cadeteAModificar.Direccion = direccion;
                cadeteAModificar.Telefono = telefono;
            }
            db.guardarCadetes(db.Cadeteria.Cadetes);
            return View("Index", db.Cadeteria.Cadetes);
        }

        public IActionResult Borrar(int id)
        {
            db.Cadeteria.Cadetes.RemoveAll(x => x.Id == id);
            db.guardarCadetes(db.Cadeteria.Cadetes);
            return View("Index", db.Cadeteria.Cadetes);
        }
    }
}
