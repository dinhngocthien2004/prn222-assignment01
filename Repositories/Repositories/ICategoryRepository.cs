using Repositories.Models;

namespace Repositories.Repositories
{
    public interface ICategoryRepository : IGenericRepository<Category>
    {
        List<Category> GetActiveCategories();
        bool IsCategoryUsedInNews(short categoryId);
    }
}
