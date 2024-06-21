using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MVC.ViewsModels;
using MVC.VsTube.Core.Interfaces;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IVideoService _videoService;
        private readonly IMapper _mapper;

        public HomeController(IVideoService videoService, IMapper mapper)
        {
            _videoService = videoService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var videos = _videoService.GetAllVideos();
            var videoViewModels = _mapper.Map<IEnumerable<VideoViewModel>>(videos);
            return View(videoViewModels);
        }

        public IActionResult Privacy()
        {
            return View();
        }
    }
}
