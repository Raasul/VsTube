namespace MVC.VsTube.Services.DTOs
{
    public class LikeDto
    {
        public int Id { get; set; }
        public string UserId { get; set; }
        public int VideoId { get; set; }
        public DateTime LikedDate { get; set; }
    }
}
