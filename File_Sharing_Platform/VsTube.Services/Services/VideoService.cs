using File_Sharing_Platform.Models;
using MVC.VsTube.Core.Interfaces;
using MVC.VsTube.Data.Repositories;

namespace MVC.VsTube.Services.Services
{
    public class VideoService : IVideoService
    {
        private readonly IVideoRepository _videoRepository;

        public VideoService(IVideoRepository videoRepository)
        {
            _videoRepository = videoRepository;
        }

        public Video GetVideo(int id)
        {
            return _videoRepository.GetVideo(id);
        }

        public IEnumerable<Video> GetAllVideos()
        {
            return _videoRepository.GetAllVideos();
        }

        public void AddVideo(Video video)
        {
            video.UploadDate = DateTime.UtcNow;
            _videoRepository.AddVideo(video);
        }

        public void UpdateVideo(Video video)
        {
            _videoRepository.UpdateVideo(video);
        }

        public void RemoveVideo(int id)
        {
            _videoRepository.RemoveVideo(id);
        }
    }
}
