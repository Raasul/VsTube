using AutoMapper;
using File_Sharing_Platform.Models;
using Microsoft.AspNetCore.Mvc;
using MVC.ViewsModels;
using MVC.VsTube.Core.Interfaces;

namespace MVC.Controllers
{
    public class SubscriptionController : Controller
    {
        private readonly ISubscriptionService _subscriptionService;
        private readonly IMapper _mapper;

        public SubscriptionController(ISubscriptionService subscriptionService, IMapper mapper)
        {
            _subscriptionService = subscriptionService;
            _mapper = mapper;
        }

        public async Task<IActionResult> Index()
        {
            var subscriptions = await _subscriptionService.GetAllSubscriptionsAsync();
            var subscriptionViewModels = _mapper.Map<IEnumerable<SubscriptionViewModel>>(subscriptions);
            return View(subscriptionViewModels);
        }

        public async Task<IActionResult> Details(int id)
        {
            var subscription = await _subscriptionService.GetSubscriptionByIdAsync(id);
            if (subscription == null)
            {
                return NotFound();
            }
            var subscriptionViewModel = _mapper.Map<SubscriptionViewModel>(subscription);
            return View(subscriptionViewModel);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(SubscriptionViewModel subscriptionViewModel)
        {
            if (ModelState.IsValid)
            {
                var subscription = _mapper.Map<Subscription>(subscriptionViewModel);
                await _subscriptionService.AddSubscriptionAsync(subscription);
                return RedirectToAction(nameof(Index));
            }
            return View(subscriptionViewModel);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var subscription = await _subscriptionService.GetSubscriptionByIdAsync(id);
            if (subscription == null)
            {
                return NotFound();
            }
            var subscriptionViewModel = _mapper.Map<SubscriptionViewModel>(subscription);
            return View(subscriptionViewModel);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(SubscriptionViewModel subscriptionViewModel)
        {
            if (ModelState.IsValid)
            {
                var subscription = _mapper.Map<Subscription>(subscriptionViewModel);
                await _subscriptionService.UpdateSubscriptionAsync(subscription);
                return RedirectToAction(nameof(Index));
            }
            return View(subscriptionViewModel);
        }

        public async Task<IActionResult> Delete(int id)
        {
            var subscription = await _subscriptionService.GetSubscriptionByIdAsync(id);
            if (subscription == null)
            {
                return NotFound();
            }
            var subscriptionViewModel = _mapper.Map<SubscriptionViewModel>(subscription);
            return View(subscriptionViewModel);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            await _subscriptionService.RemoveSubscriptionAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
