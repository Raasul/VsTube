using File_Sharing_Platform.Models;

namespace MVC.VsTube.Core.Interfaces
{
    public interface IPlaylistRepository
    {
        Playlist GetPlaylist (int id);
        IEnumerable<Playlist> GetAllPlaylist();
        void AddPlaylist(Playlist playlist);
        void UpdatePlaylist(Playlist playlist);
        void RemovePlaylist(int id);
    }
}
