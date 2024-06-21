using File_Sharing_Platform.Data;
using File_Sharing_Platform.Models;
using MVC.VsTube.Core.Interfaces;

namespace MVC.VsTube.Data.Repositories
{
    public class PlaylistRepository : IPlaylistRepository
    {
        private readonly YouTubeContext _context;

        public PlaylistRepository(YouTubeContext context)
        {
            _context = context;
        }

        public void AddPlaylist(Playlist playList)
        {
            _context.Playlists.Add(playList);
            _context.SaveChanges();
        }

        public IEnumerable<Playlist> GetAllPlaylist()
        {
            return _context.Playlists.ToList();
        }

        public Playlist GetPlaylist(int id)
        {
            return _context.Playlists.Find(id);
        }

        public void RemovePlaylist(int id)
        {            
            var playList = _context.Playlists.Find(id);
            if (playList != null)
            {
                _context.Playlists.Remove(playList);
                _context.SaveChanges();
            }

        }

        public void UpdatePlaylist(Playlist playList)
        {
            _context.Playlists.Update(playList);
            _context.SaveChanges();
        }
    }
}
