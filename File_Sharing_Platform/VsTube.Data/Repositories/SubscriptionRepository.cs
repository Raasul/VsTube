using File_Sharing_Platform.Data;
using File_Sharing_Platform.Models;
using Microsoft.EntityFrameworkCore;
using MVC.VsTube.Core.Interfaces;

namespace MVC.VsTube.Data.Repositories
{
    public class SubscriptionRepository : ISubscriptionRepository
    {
        private readonly YouTubeContext _context;

        public SubscriptionRepository(YouTubeContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Subscription>> GetAllSubscriptionsAsync()
        {
            return await _context.Subscriptions.ToListAsync();
        }

        public async Task<Subscription> GetSubscriptionByIdAsync(int id)
        {
            return await _context.Subscriptions.FindAsync(id);
        }

        public async Task AddSubscriptionAsync(Subscription subscription)
        {
            await _context.Subscriptions.AddAsync(subscription);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateSubscriptionAsync(Subscription subscription)
        {
            _context.Entry(subscription).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task RemoveSubscriptionAsync(int id)
        {
            var subscription = await _context.Subscriptions.FindAsync(id);
            if (subscription != null)
            {
                _context.Subscriptions.Remove(subscription);
                await _context.SaveChangesAsync();
            }
        }
    }
}
