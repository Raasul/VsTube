namespace File_Sharing_Platform.Models
{
    public class Video
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public DateTime UploadDate { get; set; }
        public int UserId { get; set; }

        public User User { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<Like> Likes { get; set; }
        public ICollection<Playlist> Playlists { get; set; }
    }
}
