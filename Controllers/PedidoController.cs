using Microsoft.AspNetCore.Mvc;
using VendasLanches03.Repositories;
using VendasLanches03.Repositories.Interfaces;

namespace VendasLanches03.Controllers
{
    public class PedidoController : Controller
    {
        private readonly PedidoRepository _pedidoRepository;

        public PedidoController(IPedidoRepository pedidoRepository) {

            _pedidoRepository = pedidoRepository;
        }
        public async Task<ActionResult<IEnumerable<PedidoRepository>>> List()
        {
            var pedidos = _pedidoRepository.GetAll();
            if (pedidos is null)
            {
                return NotFound("Pedidos Not Found");
            }
            return View(pedidos);
        }
    }
}
