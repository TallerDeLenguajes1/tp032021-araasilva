using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TrabajoPractico3.Models;
using TrabajoPractico3.Models.ViewModels;
using NLog;

namespace TrabajoPractico3.Controllers
{
    public class CadetesController : Controller
    {
        
        private readonly IRepositorioCadete RepoCadete;
        private readonly IMapper mapper;
        private readonly Logger _logger;
        public CadetesController(IRepositorioCadete RepoCadete, IMapper mapper, Logger _logger)
        {
            this._logger = _logger;
            this.RepoCadete = RepoCadete;
            this.mapper = mapper;
        }

        public IActionResult Index()
        {
            var listadoCadetesVM = mapper.Map<List<CadeteViewModel>>(RepoCadete.getAll());
            return View(listadoCadetesVM);
        }

        public IActionResult CreateCadete()
        {
            return View();
        }
        public IActionResult AltaCadete(CadeteViewModel cadete)
        {            
            try
            {
                if (ModelState.IsValid)
                {
                    var nuevoCadete = mapper.Map<Cadete>(cadete);    
                    RepoCadete.SaveCadete(nuevoCadete);
                    var listadoCadetesVM = mapper.Map<List<CadeteViewModel>>(RepoCadete.getAll());
                    return View("Index", listadoCadetesVM);
                }
                else
                {
                    return View("CreateCadete");
                }
            }catch(Exception ex)
            {
                _logger.Error(ex.Message);
                return View("CreateCadete");
            }
        }

        [HttpGet]
        public IActionResult Modificar(int id)
        {
            var cadetes = mapper.Map<List<CadeteViewModel>>(RepoCadete.getAll());
            CadeteViewModel cadeteADevolver = cadetes.Find(x => x.Id == id);
            if (cadeteADevolver != null)
            {
                return View(cadeteADevolver);
            }
            else
            {
                var listadoCadetesVM = mapper.Map<List<CadeteViewModel>>(RepoCadete.getAll());
                return View("Index", listadoCadetesVM);
            }                
        }
        [HttpPost]
        public IActionResult Modificar(int id, string nombre, string direccion, string telefono)
        {
            Cadete nuevo = new Cadete(nombre, direccion, telefono);
            nuevo.Id = id;
            RepoCadete.UpdateCadete(nuevo);
            var listadoCadetesVM = mapper.Map<List<CadeteViewModel>>(RepoCadete.getAll());
            return View("Index", listadoCadetesVM);
        }
        public IActionResult Borrar(int id)
        {
            RepoCadete.Delete(id);
            var listadoCadetesVM = mapper.Map<List<CadeteViewModel>>(RepoCadete.getAll());
            return View("Index", listadoCadetesVM);
        }
    }
}
