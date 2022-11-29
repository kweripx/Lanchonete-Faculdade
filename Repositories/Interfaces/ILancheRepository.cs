using VendasLanches03.Models;

namespace VendasLanches03.Repositories.Interfaces
{
    public interface ILancheRepository
    {
        Task<IEnumerable<Lanche>> GetAll();
        Task<Lanche> GetLancheById(int id);
        Task<Lanche> Create(Lanche Lanche);
        Task<Lanche> Update(Lanche Lanche);
        Task<Lanche> Delete(int id);
    }
}
