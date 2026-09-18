namespace PortfolioApp.Models
{
    /// <summary>
    /// Represents one comment left on a project's detail page.
    /// </summary>
    public class Comment
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public string Author { get; set; } = string.Empty;
        public string Message { get; set; } = string.Empty;
        public DateTime PostedAt { get; set; }
    }
}
