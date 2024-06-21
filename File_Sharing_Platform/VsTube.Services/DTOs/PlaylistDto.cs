namespace MVC.VsTube.Services.DTOs
{
    public class PlaylistDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserId { get; set; }
        public DateTime CreatedDate { get; set; }
        public List<VideoDto> Videos { get; set; } = new List<VideoDto>();
    }
}
