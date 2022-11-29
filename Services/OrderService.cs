using AutoMapper;
using VendasLanches03.DTO;
using VendasLanches03.Models;
using VendasLanches03.Repositories.Interfaces;

namespace VendasLanches03.Services
{
    public class OrderService : IOrderService
    {
        private readonly IMapper _mapper;
        private IPedidoRepository _pedidoRepository;

        public OrderService(IMapper mapper, IPedidoRepository pedidoRepository)
        {
            _mapper = mapper;
            _pedidoRepository = pedidoRepository;
        }

        public async Task AddOrder(OrderDTO orderDto)
        {
            var ordersEntity = _mapper.Map<Pedido>(orderDto);
            await _pedidoRepository.Create(ordersEntity);
            orderDto.PedidoId = ordersEntity.PedidoId;
        }

        public async Task DeleteOrder(int id)
        {
            var ordersEntity = _pedidoRepository.GetOrderById(id).Result;
            await _pedidoRepository.Delete(ordersEntity.PedidoId);
        }

        public async Task<OrderDTO> GetOrderId(int id)
        {
            var ordersEntity = await _pedidoRepository.GetOrderById(id);
            return _mapper.Map<OrderDTO>(ordersEntity);
        }

        public async Task<IEnumerable<OrderDTO>> GetOrders()
        {
            var ordersEntity = await _pedidoRepository.GetAll();
            return _mapper.Map<IEnumerable<OrderDTO>>(ordersEntity);
        }

        public async Task UpdateOrder(OrderDTO orderDto)
        {
            var ordersEntity = _mapper.Map<Pedido>(orderDto);
            await _pedidoRepository.Update(ordersEntity);
        }
    }
}
