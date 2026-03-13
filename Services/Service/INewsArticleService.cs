using Repositories.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Service
{
    public interface INewsArticleService
    {
        List<NewsArticle> GetAllNewsArticles();
        List<NewsArticle> GetActiveNewsArticles();
        List<NewsArticle> GetNewsArticlesByCreator(short creatorId);
        List<NewsArticle> GetNewsArticlesByDateRange(DateTime startDate, DateTime endDate);
        List<NewsArticle> SearchNewsArticles(string searchTerm);
        NewsArticle? GetNewsArticleById(string id);
        void AddNewsArticle(NewsArticle article, List<int> tagIds);
        void UpdateNewsArticle(NewsArticle article, List<int> tagIds);
        void DeleteNewsArticle(string id);
    }
}
