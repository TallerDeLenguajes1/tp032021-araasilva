using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
    }
}
