using File_Sharing_Platform.Models;

namespace MVC.VsTube.Core.Interfaces
{
    public interface IVideoService
    {
        Video GetVideo(int id);
        IEnumerable<Video> GetAllVideos();
        void AddVideo(Video video);
        void UpdateVideo(Video video);
        void RemoveVideo(int id);
    }
}
