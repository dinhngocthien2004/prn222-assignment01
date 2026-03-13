using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Service
{
    public interface ICategoryService
    {
        List<Category> GetAllCategories();
        List<Category> GetActiveCategories();
        Category? GetCategoryById(short id);
        void AddCategory(Category category);
        void UpdateCategory(Category category);
        bool DeleteCategory(short id);
        bool IsCategoryUsedInNews(short categoryId);
    }
}
