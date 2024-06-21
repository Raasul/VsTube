using File_Sharing_Platform.Data;
using File_Sharing_Platform.Models;
using MVC.VsTube.Core.Interfaces;

namespace MVC.VsTube.Data.Repositories
{
    public class CommentRepository : ICommentRepository
    {
        private readonly YouTubeContext _context;

        public CommentRepository(YouTubeContext context)
        {
            _context = context;
        }

        public IEnumerable<Comment> GetCommentsByVideoId(int videoId)
        {
            return _context.Comments.Where(c => c.VideoId == videoId).ToList();
        }

        public Comment GetCommentById(int id)
        {
            return _context.Comments.Find(id);
        }

        public void AddComment(Comment comment)
        {
            _context.Comments.Add(comment);
            _context.SaveChanges();
        }

        public void RemoveComment(Comment comment)
        {
            _context.Comments.Remove(comment);
            _context.SaveChanges();
        }

        public void UpdateComment(Comment comment)
        {
            _context.Comments.Update(comment);
            _context.SaveChanges();
        }
    }
}
