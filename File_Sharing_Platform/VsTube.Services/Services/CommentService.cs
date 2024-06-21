using File_Sharing_Platform.Models;
using MVC.VsTube.Core.Interfaces;

namespace MVC.VsTube.Services.Services
{
    public class CommentService : ICommentService
    {
        private readonly ICommentRepository _commentRepository;

        public CommentService(ICommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
        }

        public IEnumerable<Comment> GetCommentsByVideoId(int videoId)
        {
            return _commentRepository.GetCommentsByVideoId(videoId);
        }

        public Comment GetComment(int id)
        {
            return _commentRepository.GetCommentById(id);
        }

        public void AddComment(Comment comment)
        {
            _commentRepository.AddComment(comment);
        }

        public void RemoveComment(int id)
        {
            var comment = _commentRepository.GetCommentById(id);
            if (comment != null)
            {
                _commentRepository.RemoveComment(comment);
            }
        }

        public void UpdateComment(Comment comment)
        {
            _commentRepository.UpdateComment(comment);
        }
    }
}
