using Repositories.Models;
using Repositories.Repositories;

namespace Services.Service
{

    public class TagService : ITagService
    {
        private readonly ITagRepository _repository;

        public TagService(ITagRepository repository)
        {
            _repository = repository;
        }

        public List<Tag> GetAllTags()
        {
            return _repository.GetAll();
        }

        public Tag? GetTagById(int id)
        {
            return _repository.GetById(id);
        }
    }
}
