using File_Sharing_Platform.Models;

namespace MVC.VsTube.Core.Interfaces
{
    public interface ICommentRepository
    {
        IEnumerable<Comment> GetCommentsByVideoId(int videoId);
        Comment GetCommentById(int id);
        void AddComment(Comment comment);
        void RemoveComment(Comment comment);
        void UpdateComment(Comment comment);
    }
}
