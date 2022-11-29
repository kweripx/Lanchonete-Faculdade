using VendasLanches03.Models;

namespace VendasLanches03.Repositories.Interfaces
{
    public interface IPedidoRepository
    {

        Task<IEnumerable<Pedido>> GetAll();
        Task<IEnumerable<Pedido>> GetOrderCategory();
        Task<Pedido> GetOrderById(int id);
        Task<Pedido> Create(Pedido pedido);
        Task<Pedido> Update(Pedido pedido);
        Task<Pedido> Delete(int id);
    }
}
