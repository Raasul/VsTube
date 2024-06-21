using AutoMapper;
using File_Sharing_Platform.Models;
using Microsoft.AspNetCore.Mvc;
using MVC.ViewsModels;
using MVC.VsTube.Core.Interfaces;
using MVC.VsTube.Services.DTOs;
using MVC.VsTube.Services.Services;

namespace MVC.Controllers
{
    public class PlaylistController : Controller
    {
        private readonly IPlaylistService _playListService;
        private readonly IMapper _mapper;

        public PlaylistController(IPlaylistService playListService, IMapper mapper)
        {
            _playListService = playListService;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var playLists = _playListService.GetAllPlayLists();
            var viewModel = playLists.Select(p => _mapper.Map<PlaylistViewModel>(p)).ToList();
            return View(viewModel);
        }

        public IActionResult Details(int id)
        {
            var playList = _playListService.GetPlayList(id);
            if (playList == null)
            {
                return NotFound();
            }

            var viewModel = _mapper.Map<PlaylistViewModel>(playList);
            return View(viewModel);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(PlaylistViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                var playListDto = _mapper.Map<PlaylistDto>(viewModel);
                playListDto.CreatedDate = DateTime.UtcNow;
                _playListService.AddPlayList(playListDto);
                return RedirectToAction("Index");
            }

            return View(viewModel);
        }

        public IActionResult Edit(int id)
        {
            var playList = _playListService.GetPlayList(id);
            if (playList == null)
            {
                return NotFound();
            }

            var viewModel = _mapper.Map<PlaylistViewModel>(playList);
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Edit(int id, PlaylistViewModel viewModel)
        {
            if (id != viewModel.Id)
            {
                return BadRequest();
            }

            if (ModelState.IsValid)
            {
                var playListDto = _mapper.Map<PlaylistDto>(viewModel);
                _playListService.UpdatePlayList(playListDto);
                return RedirectToAction("Index");
            }

            return View(viewModel);
        }

        public IActionResult Delete(int id)
        {
            var playList = _playListService.GetPlayList(id);
            if (playList == null)
            {
                return NotFound();
            }

            var viewModel = _mapper.Map<PlaylistViewModel>(playList);
            return View(viewModel);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            _playListService.RemovePlayList(id);
            return RedirectToAction("Index");
        }
    }
}
