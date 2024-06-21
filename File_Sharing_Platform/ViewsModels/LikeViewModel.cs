using System.ComponentModel.DataAnnotations;

namespace MVC.ViewsModels
{
    public class LikeViewModel
    {
        public int Id { get; set; }

        [Required]
        public int VideoId { get; set; }

        [Required]
        public string UserId { get; set; }

        public DateTime LikedDate { get; set; }
    }
}
