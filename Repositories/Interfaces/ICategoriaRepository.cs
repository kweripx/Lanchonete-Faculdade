using VendasLanches03.Models;

namespace VendasLanches03.Repositories.Interfaces
{
    public interface ICategoriaRepository
    {
        Task<IEnumerable<Categoria>> GetAll();
        Task<IEnumerable<Categoria>> GetCategoriesProducts();
        Task<Categoria> GetCategoryById(int id);
        Task<Categoria> Create(Categoria categoria);
        Task<Categoria> Update(Categoria categoria);
        Task<Categoria> Delete(int id);
    }
}
