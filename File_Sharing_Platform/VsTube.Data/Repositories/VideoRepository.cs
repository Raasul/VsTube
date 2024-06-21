using File_Sharing_Platform.Data;
using File_Sharing_Platform.Models;
using MVC.VsTube.Core.Interfaces;

namespace MVC.VsTube.Data.Repositories
{
    public class VideoRepository : IVideoRepository
    {
        private readonly YouTubeContext _context;

        public VideoRepository(YouTubeContext context)
        {
            _context = context;
        }

        public Video GetVideo(int id)
        {
            return _context.Videos.Find(id);
        }

        public IEnumerable<Video> GetAllVideos()
        {
            return _context.Videos.ToList();
        }

        public void AddVideo(Video video)
        {
            _context.Videos.Add(video);
            _context.SaveChanges();
        }

        public void UpdateVideo(Video video)
        {
            _context.Videos.Update(video);
            _context.SaveChanges();
        }

        public void RemoveVideo(int id)
        {
            var video = _context.Videos.Find(id);
            if (video != null)
            {
                _context.Videos.Remove(video);
                _context.SaveChanges();
            }
        }
    }
}
