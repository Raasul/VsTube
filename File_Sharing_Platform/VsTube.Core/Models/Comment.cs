namespace File_Sharing_Platform.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime PostedDate { get; set; }
        public int UserId { get; set; }
        public int VideoId { get; set; }

        public User User { get; set; }
        public Video Video { get; set; }
    }
}
