using File_Sharing_Platform.Models;
using MVC.VsTube.Services.DTOs;

namespace MVC.VsTube.Core.Interfaces
{
    public interface IPlaylistService
    {
        PlaylistDto GetPlayList(int id);
        IEnumerable<PlaylistDto> GetAllPlayLists();
        void AddPlayList(PlaylistDto playListDto);
        void UpdatePlayList(PlaylistDto playListDto);
        void RemovePlayList(int id);
    }
}
