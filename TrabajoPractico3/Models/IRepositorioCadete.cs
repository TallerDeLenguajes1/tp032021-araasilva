using System.Collections.Generic;

namespace TrabajoPractico3.Models
{
    public interface IRepositorioCadete
    {
        List<Cadete> getAll();
        void Delete(int id);
        void SaveCadete(Cadete cadete);
        void UpdateCadete(Cadete cadete);
    }
}