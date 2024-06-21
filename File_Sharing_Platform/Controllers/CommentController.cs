using AutoMapper;
using File_Sharing_Platform.Models;
using Microsoft.AspNetCore.Mvc;
using MVC.VsTube.Core.Interfaces;
using MVC.VsTube.Services.DTOs;

namespace MVC.Controllers
{
    public class CommentController : Controller
    {
        private readonly ICommentService _commentService;
        private readonly IMapper _mapper;

        public CommentController(ICommentService commentService, IMapper mapper)
        {
            _commentService = commentService;
            _mapper = mapper;
        }

        public IActionResult Index(int videoId)
        {
            var comments = _commentService.GetCommentsByVideoId(videoId);
            var viewModel = comments.Select(c => _mapper.Map<CommentDto>(c)).ToList();
            return View(viewModel);
        }

        public IActionResult Details(int id)
        {
            var comment = _commentService.GetComment(id);
            if (comment == null)
            {
                return NotFound();
            }

            var viewModel = _mapper.Map<CommentDto>(comment);
            return View(viewModel);
        }

        public IActionResult Create(int videoId)
        {
            var viewModel = new CommentDto
            {
                VideoId = videoId
            };
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Create(CommentDto viewModel)
        {
            if (ModelState.IsValid)
            {
                var comment = _mapper.Map<Comment>(viewModel);
                _commentService.AddComment(comment);
                return RedirectToAction("Index", new { videoId = comment.VideoId });
            }

            return View(viewModel);
        }

        public IActionResult Edit(int id)
        {
            var comment = _commentService.GetComment(id);
            if (comment == null)
            {
                return NotFound();
            }

            var viewModel = _mapper.Map<CommentDto>(comment);
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Edit(CommentDto viewModel)
        {
            if (ModelState.IsValid)
            {
                var comment = _mapper.Map<Comment>(viewModel);
                _commentService.UpdateComment(comment);
                return RedirectToAction("Index", new { videoId = comment.VideoId });
            }

            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            _commentService.RemoveComment(id);
            return RedirectToAction("Index");
        }
    }
}
