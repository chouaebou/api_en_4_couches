using MonApp.Application.Interfaces;
using MonApp.Domaine.Interfaces;
using MonApp.Domaine.Models;

namespace MonApp.Application.Services
{
    public class RecetteService : IRecetteService
    {
        private readonly IRecetteRepository _repository;
        public RecetteService(IRecetteRepository recetteRepository)
        {
            _repository = recetteRepository;
        }

        public async Task<IEnumerable<Recette>> GetAllAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Recette?> GetByIdAsync(int id)
        {
            var recette = await _repository.GetByIdAsync(id);
            if (recette == null)
                return null;
            
            return recette;
        }

        public async Task<Recette> CreateAsync(Recette recette)
        {
            var recette_cree = await _repository.CreateAsync(recette);
            return recette_cree;
        }

        public async Task<Recette> UpdateAsync(int id, Recette recette)
        {
            var recette_existante = await _repository.GetByIdAsync(id);
            if (recette_existante == null)
                throw new ArgumentException($"Recette avec id {id} non trouvée.");

            recette_existante.Nom = recette.Nom;
            recette_existante.Ingredients = recette.Ingredients;
            recette_existante.Instructions = recette.Instructions;

            var recette_update = await _repository.UpdateAsync(recette_existante);
            return recette_update;
        }

        public async Task<int> DeleteAsync(int id)
        {
            var val = await _repository.DeleteAsync(id);
            return val;
        }
    }
}
