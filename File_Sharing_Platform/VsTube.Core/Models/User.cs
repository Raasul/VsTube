using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace File_Sharing_Platform.Models
{
    public class User
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PasswordHash { get; set; }
        public DateTime CreatedDate { get; set; }

        public ICollection<Video> Videos { get; set; }
        public ICollection<Playlist> Playlists { get; set; }
        public ICollection<Comment> Comments { get; set; }
        public ICollection<Like> Likes { get; set; }
        public ICollection<Subscription> Subscriptions { get; set; }
        public ICollection<Subscription> Subscribers { get; set; }

    }
}
