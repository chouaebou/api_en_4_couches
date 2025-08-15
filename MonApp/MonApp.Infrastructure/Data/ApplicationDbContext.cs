using Microsoft.EntityFrameworkCore;
using MonApp.Domaine.Models;


namespace MonApp.Infrastructure.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options) { }

        public DbSet<Recette> Recettes { get; set; }
    }
}
