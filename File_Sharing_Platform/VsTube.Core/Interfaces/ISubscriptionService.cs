using File_Sharing_Platform.Models;

namespace MVC.VsTube.Core.Interfaces
{
    public interface ISubscriptionService
    {
        Task<IEnumerable<Subscription>> GetAllSubscriptionsAsync();
        Task<Subscription> GetSubscriptionByIdAsync(int id);
        Task AddSubscriptionAsync(Subscription subscription);
        Task UpdateSubscriptionAsync(Subscription subscription);
        Task RemoveSubscriptionAsync(int id);
    }
}
