using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TrabajoPractico3.Models;
using TrabajoPractico3.Models.Entidades;

namespace TrabajoPractico3.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly IRepositorioUsuario RepoUsuario;

        public UsuariosController(IRepositorioUsuario RepoUsuario)
        {
            this.RepoUsuario = RepoUsuario;
        }

        public IActionResult Index()
        { 
            return View();
        }

        [HttpPost]
        public IActionResult Login(string nombreUsuario, string clave)
        {
            int? usuarioId = RepoUsuario.GetUsuarioID(nombreUsuario, clave);
            if(usuarioId != null)
            {
                HttpContext.Session.SetInt32("Id", usuarioId.Value);
                HttpContext.Session.SetString("usuario", nombreUsuario);
                HttpContext.Session.SetString("contraseña", clave);
                return View("../Home/Index");
            }
            else
            {
                return View("Error");
            }
           
        }
        public IActionResult CreateUsuario()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CreateUsuario(string nombreUsuario, string clave, string email)
        {
            Usuario nuevoUsuario = new Usuario(nombreUsuario, email, clave);
            RepoUsuario.SaveUsuario(nuevoUsuario);
            return View("../Home/Index");
        }
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
