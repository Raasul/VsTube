namespace File_Sharing_Platform.Models
{
    public class Playlist
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int UserId { get; set; }
        public DateTime CreateDate { get; set; }

        public User User { get; set; }
        public ICollection<Video> Videos { get; set; }
    }
}
