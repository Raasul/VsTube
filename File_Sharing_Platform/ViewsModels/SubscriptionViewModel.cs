using System.ComponentModel.DataAnnotations;

namespace MVC.ViewsModels
{
    public class SubscriptionViewModel
    {
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public int SubscribedToUserId { get; set; }

        public DateTime SubscribedDate { get; set; }
    }
}
