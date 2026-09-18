namespace PortfolioApp.Models
{
    /// <summary>
    /// Represents one GitHub project shown on the portfolio.
    /// </summary>
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty; // e.g. Prelim, Midterm, Prefinal
        public string Description { get; set; } = string.Empty;
        public string GitHubUrl { get; set; } = string.Empty;
        public string ThumbnailUrl { get; set; } = string.Empty;
    }
}
