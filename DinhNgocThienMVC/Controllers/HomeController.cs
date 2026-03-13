using Microsoft.AspNetCore.Mvc;
using Repositories.Models;
using Services.Service;
using System.Diagnostics;

namespace DinhNgocThienMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly INewsArticleService _newsArticleService;

        public HomeController(ILogger<HomeController> logger, INewsArticleService newsArticleService)
        {
            _logger = logger;
            _newsArticleService = newsArticleService;
        }

        public IActionResult Index(string searchTerm)
        {
            // Lấy tất cả bài viết active, include Category và Tags
            var articles = _newsArticleService.GetAllNewsArticles();

            // Lọc theo searchTerm nếu có
            if (!string.IsNullOrEmpty(searchTerm))
            {
                articles = articles.Where(a =>
                    (!string.IsNullOrEmpty(a.NewsTitle) && a.NewsTitle.Contains(searchTerm, StringComparison.OrdinalIgnoreCase)) ||
                    (!string.IsNullOrEmpty(a.Headline) && a.Headline.Contains(searchTerm, StringComparison.OrdinalIgnoreCase)) ||
                    (a.Category != null && a.Category.CategoryName.Contains(searchTerm, StringComparison.OrdinalIgnoreCase)) ||
                    (a.NewsTags.Any(t => t.Tag != null && t.Tag.TagName.Contains(searchTerm, StringComparison.OrdinalIgnoreCase)))
                ).ToList();
            }

            return View(articles); // Truyền thẳng List<NewsArticle> vào View
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
