using System.ComponentModel.DataAnnotations;

namespace PortfolioApp.Models
{
    public class CommentInputModel
    {
        [Required]
        public int ProjectId { get; set; }

        [Required]
        [StringLength(60)]
        public string Author { get; set; } = string.Empty;

        [Required]
        [StringLength(500)]
        public string Message { get; set; } = string.Empty;
    }
}
