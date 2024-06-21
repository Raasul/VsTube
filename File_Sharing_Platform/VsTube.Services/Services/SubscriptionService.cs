using File_Sharing_Platform.Models;
using MVC.VsTube.Core.Interfaces;

namespace MVC.VsTube.Services.Services
{
    public class SubscriptionService : ISubscriptionService
    {
        private readonly ISubscriptionRepository _subscriptionRepository;

        public SubscriptionService(ISubscriptionRepository subscriptionRepository)
        {
            _subscriptionRepository = subscriptionRepository;
        }

        public async Task<IEnumerable<Subscription>> GetAllSubscriptionsAsync()
        {
            return await _subscriptionRepository.GetAllSubscriptionsAsync();
        }

        public async Task<Subscription> GetSubscriptionByIdAsync(int id)
        {
            return await _subscriptionRepository.GetSubscriptionByIdAsync(id);
        }

        public async Task AddSubscriptionAsync(Subscription subscription)
        {
            await _subscriptionRepository.AddSubscriptionAsync(subscription);
        }

        public async Task UpdateSubscriptionAsync(Subscription subscription)
        {
            await _subscriptionRepository.UpdateSubscriptionAsync(subscription);
        }

        public async Task RemoveSubscriptionAsync(int id)
        {
            await _subscriptionRepository.RemoveSubscriptionAsync(id);
        }
    }
}
