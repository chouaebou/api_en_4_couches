

using MonApp.Domaine.Models;

namespace MonApp.Domaine.Interfaces
{
    public interface IRecetteRepository
    {
        Task<IEnumerable<Recette>> GetAllAsync();
        Task<Recette> GetByIdAsync(int id);
        Task<Recette> CreateAsync(Recette recette);
        Task<Recette> UpdateAsync(Recette recette);
        Task<int> DeleteAsync(int id);

    }
}
