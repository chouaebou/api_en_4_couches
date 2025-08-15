using MonApp.Domaine.Models;

namespace MonApp.Application.Interfaces
{
    public interface IRecetteService
    {
        Task<IEnumerable<Recette>> GetAllAsync();
        Task<Recette?> GetByIdAsync(int id);
        Task<Recette> CreateAsync(Recette recette);
        Task<Recette> UpdateAsync(int id, Recette recette);
        Task<int> DeleteAsync(int id);

    }
}
