using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using VendasLanches03.DTO;
using VendasLanches03.Services;

namespace VendasLanches03.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidosController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public PedidosController(IOrderService orderService)
        {
            _orderService = orderService;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<OrderDTO>>> Get()
        {
            var ordersDto = await _orderService.GetOrders();
            if (ordersDto == null)
            {
                return NotFound("Order not found");
            }
            return Ok(ordersDto);
        }
        [HttpGet("{id:int}", Name= "GetOrder")]
        public async Task<ActionResult<IEnumerable<OrderDTO>>> GetById(int id)
        {
            var ordersDto = await _orderService.GetOrderId(id);
            if (ordersDto == null)
            {
                return NotFound("Order not found");
            }
            return Ok(ordersDto);
        }
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] OrderDTO orderDto)
        {
            if (orderDto == null)
            {
                return BadRequest("Invalid order");
            }
            await _orderService.AddOrder(orderDto);
            return new CreatedAtRouteResult("Getordedr", new { id = orderDto.PedidoId }, orderDto);
        }
        [HttpPut("{id:int}")]
        public async Task<ActionResult> Put(int id, [FromBody] OrderDTO orderDto)
        {
            if (id != orderDto.PedidoId)
            {
                return BadRequest(orderDto.PedidoId);
            }
            if (orderDto == null)
            {
                return BadRequest();
            }
            await _orderService.UpdateOrder(orderDto);
            return Ok(orderDto);
        }
        [HttpDelete("{id:int}")]
        public async Task<ActionResult<OrderDTO>> Delete(int id)
        {
            var orderDto = await _orderService.GetOrderId(id);
            if (orderDto == null) { return NotFound("Order not found"); }

            await _orderService.DeleteOrder(id);
            return Ok(orderDto);
        }
    }
}
