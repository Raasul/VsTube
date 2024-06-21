using System.ComponentModel.DataAnnotations;

namespace MVC.ViewsModels
{
    public class VideoViewModel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100, MinimumLength = 3)]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string Url { get; set; }

        public DateTime UploadDate { get; set; }
    }
}
