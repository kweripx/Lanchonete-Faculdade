
using Microsoft.EntityFrameworkCore;
using VendasLanches03.Context;
using VendasLanches03.Models;
using VendasLanches03.Repositories.Interfaces;

namespace VendasLanches03.Repositories
{
    public class LancheRepository : ILancheRepository
    {

        private readonly APPDbContext _context;

        public LancheRepository(APPDbContext context)
        {
            _context = context;

        }

        public async Task<Lanche> Create(Lanche Lanche)
        {
            _context.Lanches.Add(Lanche);
            await _context.SaveChangesAsync();
            return Lanche;
        }

        public async Task<Lanche> Update(Lanche Lanche)
        {
           _context.Entry(Lanche).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return Lanche;
        }

        public async Task<Lanche> Delete(int id)
        {
            var lanche = await GetLancheById(id);
            _context.Lanches.Remove(lanche);
            await _context.SaveChangesAsync();
            return lanche;
        }

        public async Task<IEnumerable<Lanche>> GetAll()
        {
            return await _context.Lanches.ToListAsync();
        }

        public async Task<Lanche> GetLancheById(int id)
        {
            return await _context.Lanches.Where(c => c.LancheId == id).FirstOrDefaultAsync();
        }
    }
}