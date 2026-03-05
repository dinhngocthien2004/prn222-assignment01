using HaQuangHuy_SE18C.NET_A01.Models;

namespace HaQuangHuy_SE18C.NET_A01.Repositories
{
    public interface INewsArticleRepository : IGenericRepository<NewsArticle>
    {
        List<NewsArticle> GetActiveNewsArticles();
        List<NewsArticle> GetNewsArticlesByCreator(short creatorId);
        List<NewsArticle> GetNewsArticlesByDateRange(DateTime startDate, DateTime endDate);
        List<NewsArticle> SearchNewsArticles(string searchTerm);
    }
}
