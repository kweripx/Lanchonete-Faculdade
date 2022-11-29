using VendasLanches03.DTO;

namespace VendasLanches03.Services
{
    public interface IOrderService
    {
        Task<IEnumerable<OrderDTO>> GetOrders();
        Task<OrderDTO> GetOrderId(int id);
        Task AddOrder(OrderDTO orderDto);
        Task UpdateOrder(OrderDTO orderDto);
        Task DeleteOrder(int id);
    }
}
