using Repositories.Models;

namespace Repositories.Repositories
{
    public class TagRepository : GenericRepository<Tag>, ITagRepository
    {
        public TagRepository(FUNewsManagementContext context) : base(context)
        {
        }
    }
}
