using System.Collections.Generic;

namespace TrabajoPractico3.Models.Entidades
{
    public interface IRepositorioUsuario
    {
        void Delete(int id);
        List<Usuario> getAll();
        void SaveUsuario(Usuario usuario);
        void UpdateUsuario(Usuario usuario);
    }
}