using AutoMapper;
using File_Sharing_Platform.Models;
using MVC.ViewsModels;
using MVC.VsTube.Services.DTOs;

namespace MVC.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Comment, CommentViewModel>().ReverseMap();
            CreateMap<Comment, CommentDto>().ReverseMap();

            CreateMap<Like, LikeViewModel>().ReverseMap();
            CreateMap<Like, LikeDto>().ReverseMap();

            CreateMap<Playlist, PlaylistViewModel>().ReverseMap();
            CreateMap<Playlist, PlaylistDto>().ReverseMap();

            CreateMap<Subscription, SubscriptionViewModel>().ReverseMap();
            CreateMap<Subscription, SubscriptionDto>().ReverseMap();

            CreateMap<User, UserViewModel>().ReverseMap();
            CreateMap<User, UserDto>().ReverseMap();

            CreateMap<Video, VideoViewModel>().ReverseMap();
            CreateMap<Video, VideoDto>().ReverseMap();

        }
    }
}
