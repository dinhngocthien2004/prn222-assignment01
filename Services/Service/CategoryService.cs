using Repositories.Models;
using Repositories.Repositories;

namespace Services.Service
{  
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _repository;

        public CategoryService(ICategoryRepository repository)
        {
            _repository = repository;
        }

        public List<Category> GetAllCategories()
        {
            return _repository.GetAll();
        }

        public List<Category> GetActiveCategories()
        {
            return _repository.GetActiveCategories();
        }

        public Category? GetCategoryById(short id)
        {
            return _repository.GetById(id);
        }

        public void AddCategory(Category category)
        {
            _repository.Add(category);
            _repository.Save();
        }

        public void UpdateCategory(Category category)
        {
            _repository.Update(category);
            _repository.Save();
        }

        public bool DeleteCategory(short id)
        {
            if (_repository.IsCategoryUsedInNews(id))
            {
                return false;
            }

            var category = _repository.GetById(id);
            if (category != null)
            {
                _repository.Delete(category);
                _repository.Save();
                return true;
            }
            return false;
        }

        public bool IsCategoryUsedInNews(short categoryId)
        {
            return _repository.IsCategoryUsedInNews(categoryId);
        }
    }
}
