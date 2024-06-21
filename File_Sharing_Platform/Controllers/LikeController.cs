using AutoMapper;
using File_Sharing_Platform.Models;
using Microsoft.AspNetCore.Mvc;
using MVC.ViewsModels;
using MVC.VsTube.Core.Interfaces;
using MVC.VsTube.Services.DTOs;

namespace MVC.Controllers
{
    public class LikeController : Controller
    {
        private readonly ILikeService _likeService;
        private readonly IMapper _mapper;

        public LikeController(ILikeService likeService, IMapper mapper)
        {
            _likeService = likeService;
            _mapper = mapper;
        }

        public IActionResult Index(int videoId)
        {
            var likes = _likeService.GetLikesByVideoId(videoId);
            var viewModel = likes.Select(l => _mapper.Map<LikeViewModel>(l)).ToList();
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Create(LikeViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var likeDto = _mapper.Map<LikeDto>(viewModel);
                likeDto.LikedDate = DateTime.UtcNow;
                _likeService.AddLike(likeDto);
                return RedirectToAction("Index", new { videoId = likeDto.VideoId });
            }

            return View(viewModel);
        }

        public IActionResult Details(int id)
        {
            var like = _likeService.GetLike(id);
            if (like == null)
            {
                return NotFound();
            }

            var viewModel = _mapper.Map<LikeViewModel>(like);
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            _likeService.RemoveLike(id);
            return RedirectToAction("Index");
        }
    }
}
