using MonApp.Application.Interfaces;
using MonApp.Domaine.Interfaces;

namespace MonApp.Application.Services
{
    public class ArticlesService: IArticlesService
    {
        private readonly IArticlesRepository _articlesRepository;
        public ArticlesService(IArticlesRepository articlesRepository)
        {
            _articlesRepository = articlesRepository;
        }
    }
}
