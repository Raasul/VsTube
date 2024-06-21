using File_Sharing_Platform.Models;
using Microsoft.AspNetCore.Mvc;
using MVC.VsTube.Core.Interfaces;

namespace MVC.Controllers
{
    public class VideoController : Controller
    {
        private readonly IVideoService _videoService;

        public VideoController(IVideoService videoService)
        {
            _videoService = videoService;
        }

        public IActionResult Index()
        {
            var videos = _videoService.GetAllVideos();
            return View(videos);
        }

        public IActionResult Details(int id)
        {
            var video = _videoService.GetVideo(id);
            if (video == null)
            {
                return NotFound();
            }
            return View(video);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Video video)
        {
            if (ModelState.IsValid)
            {
                _videoService.AddVideo(video);
                return RedirectToAction(nameof(Index));
            }
            return View();
        }

        public IActionResult Edit(int id)
        {
            var video = _videoService.GetVideo(id);
            if (video == null)
            {
                return NotFound();
            }
            return View(video);
        }

        [HttpPost]
        public IActionResult Edit(Video video)
        {
            if (ModelState.IsValid)
            {
                _videoService.UpdateVideo(video);
                return RedirectToAction(nameof(Index));
            }
            return View(video);
        }

        public IActionResult Delete(int id)
        {
            var video = _videoService.GetVideo(id);
            if (video == null)
            {
                return NotFound();
            }
            return View(video);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            _videoService.RemoveVideo(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
