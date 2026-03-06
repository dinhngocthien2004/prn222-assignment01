using Repositories.Models;

namespace Repositories.Repositories
{
    public interface INewsTagRepository : IGenericRepository<NewsTag>
    {
        List<NewsTag> GetTagsByNewsArticleId(string newsArticleId);
        void DeleteByNewsArticleId(string newsArticleId);
    }
}
