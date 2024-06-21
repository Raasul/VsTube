using File_Sharing_Platform.Models;
using Microsoft.EntityFrameworkCore;
namespace File_Sharing_Platform.Data
{
    public class YouTubeContext : DbContext
    {
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Like> Likes { get; set; }
        public DbSet<Playlist> Playlists { get; set; }
        public DbSet<Subscription> Subscriptions { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Video> Videos { get; set; }

        public YouTubeContext(DbContextOptions<YouTubeContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Subscription>()
                .HasOne(s => s.Subscriber)
                .WithMany(u => u.Subscriptions)
                .HasForeignKey(s => s.UserId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Subscription>()
                .HasOne(s => s.SubscribedTo)
                .WithMany(u => u.Subscribers)
                .HasForeignKey(s => s.SubscribedToUserId)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<User>()
                .HasMany(s => s.Comments)
                .WithOne(u => u.User)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<User>()
                .HasMany(s => s.Likes)
                .WithOne(u => u.User)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<User>()
                .HasMany(s => s.Playlists)
                .WithOne(u => u.User)
                .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(modelBuilder);
        }
    }
}