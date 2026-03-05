using HaQuangHuy_SE18C.NET_A01.Models;

namespace HaQuangHuy_SE18C.NET_A01.Repositories
{
    public interface ICategoryRepository : IGenericRepository<Category>
    {
        List<Category> GetActiveCategories();
        bool IsCategoryUsedInNews(short categoryId);
    }
}
