using PortfolioApp.Models;

namespace PortfolioApp.Data
{
    /// <summary>
    /// Very simple in-memory comment storage, shared across all requests for the
    /// lifetime of the running application (comments reset when the app restarts).
    /// </summary>
    public static class CommentStore
    {
        private static readonly object _lock = new();
        private static int _nextId = 1;

        private static readonly List<Comment> _comments = new()
        {
            new Comment { Id = 0, ProjectId = 1, Author = "Visitor", Message = "Nice, clean layout for a prelim activity!", PostedAt = DateTime.Now.AddDays(-3) },
            new Comment { Id = 0, ProjectId = 13, Author = "Classmate", Message = "Great teamwork on this pre-final project.", PostedAt = DateTime.Now.AddDays(-1) },
        };

        static CommentStore()
        {
            foreach (var c in _comments)
            {
                c.Id = _nextId++;
            }
        }

        public static List<Comment> GetForProject(int projectId)
        {
            lock (_lock)
            {
                return _comments
                    .Where(c => c.ProjectId == projectId)
                    .OrderByDescending(c => c.PostedAt)
                    .ToList();
            }
        }

        public static void Add(int projectId, string author, string message)
        {
            lock (_lock)
            {
                _comments.Add(new Comment
                {
                    Id = _nextId++,
                    ProjectId = projectId,
                    Author = string.IsNullOrWhiteSpace(author) ? "Anonymous" : author.Trim(),
                    Message = message.Trim(),
                    PostedAt = DateTime.Now
                });
            }
        }
    }
}
