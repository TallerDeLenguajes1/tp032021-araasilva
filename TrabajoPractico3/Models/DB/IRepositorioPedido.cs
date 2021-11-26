using System.Collections.Generic;

namespace TrabajoPractico3.Models
{
    public interface IRepositorioPedido
    {
        void Delete(int id);
        List<Pedido> getAll();
        void SavePedido(Pedido pedido);
        void UpdatePedido(Pedido pedido);
    }
}