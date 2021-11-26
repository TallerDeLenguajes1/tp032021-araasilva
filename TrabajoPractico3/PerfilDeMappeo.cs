using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TrabajoPractico3.Models;
using TrabajoPractico3.Models.Entidades;
using TrabajoPractico3.Models.ViewModels;

namespace TrabajoPractico3
{
    public class PerfilDeMappeo : Profile
    {
        public PerfilDeMappeo()
        {
            //Cadete
            CreateMap<Cadete, CadeteViewModel>().ReverseMap();

            CreateMap<Pedido, PedidoViewModel>().ReverseMap();

            CreateMap<Usuario, UsuarioViewModel>().ReverseMap();

            CreateMap<Cliente, ClienteViewModel>().ReverseMap();

        }
    }
}
