using File_Sharing_Platform.Data;
using File_Sharing_Platform.Models;
using MVC.VsTube.Core.Interfaces;

namespace MVC.VsTube.Data.Repositories
{
    public class LikeRepository : ILikeRepository
    {
        private readonly YouTubeContext _context;

        public LikeRepository(YouTubeContext context)
        {
            _context = context;
        }

        public Like GetLike(int id)
        {
            return _context.Likes.Find(id);
        }

        public IEnumerable<Like> GetLikesByVideoId(int videoId)
        {
            return _context.Likes.Where(l => l.VideoId == videoId).ToList();
        }

        public void AddLike(Like like)
        {
            _context.Likes.Add(like);
            _context.SaveChanges();
        }

        public void RemoveLike(int id)
        {
            var like = _context.Likes.Find(id);
            if (like != null)
            {
                _context.Likes.Remove(like);
                _context.SaveChanges();
            }
        }
    }
}
