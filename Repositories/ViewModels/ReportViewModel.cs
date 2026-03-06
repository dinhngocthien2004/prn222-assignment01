namespace Repositories.ViewModels
{
    public class ReportViewModel
    {
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int TotalArticles { get; set; }
        public int ActiveArticles { get; set; }
        public int InactiveArticles { get; set; }
        public Dictionary<string, int> ArticlesByCategory { get; set; } = new Dictionary<string, int>();
    }
}
