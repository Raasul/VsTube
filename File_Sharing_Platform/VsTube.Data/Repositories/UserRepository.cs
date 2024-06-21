using File_Sharing_Platform.Data;
using File_Sharing_Platform.Models;
using MVC.VsTube.Core.Interfaces;

namespace MVC.VsTube.Data.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly YouTubeContext _context;

        public UserRepository(YouTubeContext context)
        {
            _context = context;
        }

        public User GetUser(int id)
        {
            return _context.Users.Find(id);
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _context.Users.ToList();
        }

        public void AddUser(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }

        public void UpdateUser(User user)
        {
            _context.Users.Update(user);
            _context.SaveChanges();
        }

        public void RemoveUser(int id)
        {
            var user = _context.Users.Find(id);
            if (user != null)
            {
                _context.Users.Remove(user);
                _context.SaveChanges();
            }
        }
     }
}
