using AutoMapper;
using File_Sharing_Platform.Models;
using MVC.VsTube.Core.Interfaces;
using MVC.VsTube.Data.Repositories;
using MVC.VsTube.Services.DTOs;

namespace MVC.VsTube.Services.Services
{
    public class PlaylistService : IPlaylistService
    {
        private readonly IPlaylistRepository _playListRepository;
        private readonly IMapper _mapper;

        public PlaylistService(IPlaylistRepository playListRepository, IMapper mapper)
        {
            _playListRepository = playListRepository;
            _mapper = mapper;
        }
        public PlaylistDto GetPlayList(int id)
        {
            var playList = _playListRepository.GetPlaylist(id);
            return _mapper.Map<PlaylistDto>(playList);
        }

        public IEnumerable<PlaylistDto> GetAllPlayLists()
        {
            var playLists = _playListRepository.GetAllPlaylist();
            return _mapper.Map<IEnumerable<PlaylistDto>>(playLists);
        }

        public void AddPlayList(PlaylistDto playListDto)
        {
            var playList = _mapper.Map<Playlist>(playListDto);
            _playListRepository.AddPlaylist(playList);
        }

        public void UpdatePlayList(PlaylistDto playListDto)
        {
            var playList = _mapper.Map<Playlist>(playListDto);
            _playListRepository.UpdatePlaylist(playList);
        }

        public void RemovePlayList(int id)
        {
            _playListRepository.RemovePlaylist(id);
        }
    }
}
