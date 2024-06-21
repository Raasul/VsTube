namespace File_Sharing_Platform.Models
{
    public class Subscription
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int SubscribedToUserId { get; set; }
        public DateTime SubscribedDate { get; set; }

        public User Subscriber { get; set; }
        public User SubscribedTo { get; set; }
    }
}
