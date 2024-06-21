namespace MVC.VsTube.Services.DTOs
{
    public class CommentDto
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime PostedDate { get; set; }
        public int VideoId { get; set; }
        public string UserId { get; set; }

    }
}
