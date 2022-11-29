using Microsoft.EntityFrameworkCore;
using VendasLanches03.Context;
using VendasLanches03.Models;
using VendasLanches03.Repositories.Interfaces;

namespace VendasLanches03.Repositories
{
    public class CategoriaRepository : ICategoriaRepository
    {
        private readonly APPDbContext _context;
        public CategoriaRepository(APPDbContext context)
        {
            _context = context;
        }

        public async Task<Categoria> Create(Categoria categoria)
        {
            _context.Categorias.Add(categoria);
            await _context.SaveChangesAsync();
            return categoria;
        }

        public async Task<Categoria> Update(Categoria categoria)
        {
            _context.Entry(categoria).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return categoria;
        }

        public async Task<Categoria> Delete(int id)
        {
            var categoria = await GetCategoryById(id);
            _context.Categorias.Remove(categoria);
            await _context.SaveChangesAsync();
            return categoria;
        }

        public async Task<IEnumerable<Categoria>> GetAll()
        {
            return await _context.Categorias.ToListAsync();
        }

        public async Task<IEnumerable<Categoria>> GetCategoriesProducts()
        {
            return await _context.Categorias.Include(c => c.Lanche).ToListAsync();
        }

        public async Task<Categoria> GetCategoryById(int id)
        {
            return await _context.Categorias.Where(c => c.CategoriaId == id).FirstOrDefaultAsync();
        }
    }
}
