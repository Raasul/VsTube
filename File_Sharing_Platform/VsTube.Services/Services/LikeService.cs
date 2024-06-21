using AutoMapper;
using File_Sharing_Platform.Models;
using MVC.VsTube.Core.Interfaces;
using MVC.VsTube.Services.DTOs;

namespace MVC.VsTube.Services.Services
{
    public class LikeService : ILikeService
    {
        private readonly ILikeRepository _likeRepository;
        private readonly IMapper _mapper;

        public LikeService(ILikeRepository likeRepository, IMapper mapper)
        {
            _likeRepository = likeRepository;
            _mapper = mapper;
        }

        public LikeDto GetLike(int id)
        {
            var like = _likeRepository.GetLike(id);
            return _mapper.Map<LikeDto>(like);
        }

        public IEnumerable<LikeDto> GetLikesByVideoId(int videoId)
        {
            var likes = _likeRepository.GetLikesByVideoId(videoId);
            return _mapper.Map<IEnumerable<LikeDto>>(likes);
        }

        public void AddLike(LikeDto likeDto)
        {
            var like = _mapper.Map<Like>(likeDto);
            like.LikedDate = DateTime.UtcNow;
            _likeRepository.AddLike(like);
        }

        public void RemoveLike(int id)
        {
            _likeRepository.RemoveLike(id);
        }
    }
}
