namespace MVC.VsTube.Services.DTOs
{
    public class SubscriptionDto
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int SubscribedToUserId { get; set; }
        public DateTime SubscribedDate { get; set; }
    }
}
