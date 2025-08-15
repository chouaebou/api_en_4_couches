using Microsoft.EntityFrameworkCore;
using MonApp.Domaine.Interfaces;
using MonApp.Domaine.Models;
using MonApp.Infrastructure.Data;

namespace MonApp.Infrastructure.Repositories
{
    public class RecetteRepository: IRecetteRepository
    {
        private readonly ApplicationDbContext _context;

        public RecetteRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Recette>> GetAllAsync() => await _context.Recettes.ToListAsync();

        public async Task<Recette?> GetByIdAsync(int id) => await _context.Recettes.FindAsync(id);

        public async Task<Recette> CreateAsync(Recette recette)
        {
            _context.Recettes.Add(recette);
            await _context.SaveChangesAsync();
            return recette;
        }

        public async Task<Recette> UpdateAsync(Recette recette)
        {
            _context.Recettes.Update(recette);
            await _context.SaveChangesAsync();
            return recette;
        }

        public async Task<int> DeleteAsync(int id)
        {
            var recette = await _context.Recettes.FindAsync(id);
            if (recette != null)
            {
                _context.Recettes.Remove(recette);
                return await _context.SaveChangesAsync();
            }
            return -1;
        }

    }
}
