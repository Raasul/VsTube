namespace File_Sharing_Platform.Models
{
    public class Like
    {
        public int Id { get; set; }
        public int VideoId { get; set; }
        public int UserId { get; set; }  
        public DateTime LikedDate { get; set; }

        public User User { get; set; }
        public Video Video { get; set; }
    }
}
