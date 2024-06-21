using File_Sharing_Platform.Models;
using MVC.VsTube.Core.Interfaces;

namespace MVC.VsTube.Services.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public User GetUser(int id)
        {
            return _userRepository.GetUser(id);
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _userRepository.GetAllUsers();
        }

        public void AddUser(User user)
        {
            user.CreatedDate = DateTime.UtcNow;
            _userRepository.AddUser(user);
        }

        public void UpdateUser(User user)
        {
            _userRepository.UpdateUser(user);
        }

        public void RemoveUser(int id)
        {
            _userRepository.RemoveUser(id);
        }
    }
}
