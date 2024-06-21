using System.ComponentModel.DataAnnotations;

namespace MVC.ViewsModels
{
    public class CommentViewModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(500, MinimumLength = 3)]
        public string Content { get; set; }

        public DateTime PostedDate { get; set; }

        [Required]
        public int VideoId { get; set; }

        [Required]
        public string UserId { get; set; }
    }
}
