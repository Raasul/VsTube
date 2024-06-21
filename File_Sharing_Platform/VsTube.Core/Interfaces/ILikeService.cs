using File_Sharing_Platform.Models;
using MVC.VsTube.Services.DTOs;

namespace MVC.VsTube.Core.Interfaces
{
    public interface ILikeService
    {
        LikeDto GetLike(int id);
        IEnumerable<LikeDto> GetLikesByVideoId(int videoId);
        void AddLike(LikeDto likeDto);
        void RemoveLike(int id);
    }
}
