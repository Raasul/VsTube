using File_Sharing_Platform.Models;

namespace MVC.VsTube.Core.Interfaces
{
    public interface ICommentService
    {
        IEnumerable<Comment> GetCommentsByVideoId(int videoId);
        Comment GetComment(int id);
        void AddComment(Comment comment);
        void RemoveComment(int id);
        void UpdateComment(Comment comment);
    }
}
