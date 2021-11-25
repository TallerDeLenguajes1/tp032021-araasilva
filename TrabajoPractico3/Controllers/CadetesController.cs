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
        private readonly IRepositorioCadete RepoCadete;
        public CadetesController(Logger log,IRepositorioCadete RepoCadete)
        {
            _logger = log;
            _logger.Debug("NLog injected into HomeController");
            this.RepoCadete = RepoCadete;
        }

        public IActionResult Index()
        {
            return View(RepoCadete.getAll());
        }

        public IActionResult CreateCadete()
        {
            return View();
        }
        public IActionResult AltaCadete(string nombre, string direccion, string telefono)
        {
            Cadete nuevoCadete = new Cadete(nombre, direccion, telefono);
            RepoCadete.SaveCadete(nuevoCadete);
            return View("Index", RepoCadete.getAll());
        }

        public IActionResult Modificar(int id)
        {
            List<Cadete> cadetes = RepoCadete.getAll();
            Cadete cadeteADevolver = cadetes.Find(x => x.Id == id);
            if (cadeteADevolver != null)
                return View(cadeteADevolver);
            else
                return View("Index");
        }
        public IActionResult ModificarCadete(int id, string nombre, string direccion, string telefono)
        {
            Cadete nuevo = new Cadete(nombre, direccion, telefono);
            nuevo.Id = id;
            RepoCadete.UpdateCadete(nuevo);         
            return View("Index", RepoCadete.getAll());
        }
            

        public IActionResult Borrar(int id)
        {
            RepoCadete.Delete(id);
            return View("Index", RepoCadete.getAll());
        }
    }
}
