using System.Collections.Generic;

namespace TrabajoPractico3.Models.Entidades
{
    public interface IRepositorioUsuario
    {
        void Delete(int id);
        int GetUsuarioID(string usuario, string contrasenia);
        void SaveUsuario(Usuario usuario);
        void UpdateUsuario(Usuario usuario);
    }
}