using Repositories.Models;

namespace Repositories.Repositories
{
    public interface INewsArticleRepository : IGenericRepository<NewsArticle>
    {
        List<NewsArticle> GetActiveNewsArticles();
        List<NewsArticle> GetNewsArticlesByCreator(short creatorId);
        List<NewsArticle> GetNewsArticlesByDateRange(DateTime startDate, DateTime endDate);
        List<NewsArticle> SearchNewsArticles(string searchTerm);
    }
}
