using System.ComponentModel.DataAnnotations;

namespace MVC.ViewsModels
{
    public class PlaylistViewModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string Name { get; set; }

        public string UserId { get; set; }
        public DateTime CreatedDate { get; set; }
        public List<VideoViewModel> Videos { get; set; } = new List<VideoViewModel>();
    }
}
