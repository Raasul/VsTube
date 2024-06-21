using File_Sharing_Platform.Models;

namespace MVC.VsTube.Core.Interfaces
{
    public interface ILikeRepository
    {
        Like GetLike(int id);
        IEnumerable<Like> GetLikesByVideoId(int videoId);
        void AddLike(Like like);
        void RemoveLike(int id);
    }
}
