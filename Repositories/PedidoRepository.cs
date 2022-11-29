using Microsoft.EntityFrameworkCore;
using VendasLanches03.Context;
using VendasLanches03.Models;
using VendasLanches03.Repositories.Interfaces;
namespace VendasLanches03.Repositories
{
    public class PedidoRepository : IPedidoRepository
    {
        private readonly APPDbContext _context;
        public PedidoRepository(APPDbContext context)
        {
            _context = context;
        }
        public async Task<Pedido> Create(Pedido pedido)
        {
            _context.Pedidos.Add(pedido);
            await _context.SaveChangesAsync();
            return pedido;
        }

        public async Task<Pedido> Update(Pedido pedido)
        {
            _context.Entry(pedido).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return pedido;
        }

        public async Task<Pedido> Delete(int id)
        {
            var pedido = await GetOrderById(id);
            _context.Pedidos.Remove(pedido);
            await _context.SaveChangesAsync();
            return pedido;
        }

        public async Task<IEnumerable<Pedido>> GetAll()
        {
            return await _context.Pedidos.ToListAsync();
        }

        public async Task<Pedido> GetOrderById(int id)
        {
            return await _context.Pedidos.Include(c => c.PedidoId == id).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Pedido>> GetOrderCategory()
        {
            return await _context.Pedidos.Include(c => c.PedidoId).ToListAsync();
        }
    }
}
