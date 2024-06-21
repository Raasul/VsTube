using File_Sharing_Platform.Models;
using MVC.VsTube.Data.Repositories;

namespace MVC.VsTube.Core.Interfaces
{
    public interface ISubscriptionRepository
    {
        Task<IEnumerable<Subscription>> GetAllSubscriptionsAsync();
        Task<Subscription> GetSubscriptionByIdAsync(int id);
        Task AddSubscriptionAsync(Subscription subscription);
        Task UpdateSubscriptionAsync(Subscription subscription);
        Task RemoveSubscriptionAsync(int id);
    }
}
