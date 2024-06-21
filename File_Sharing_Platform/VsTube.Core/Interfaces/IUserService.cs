using File_Sharing_Platform.Models;

namespace MVC.VsTube.Core.Interfaces
{
    public interface IUserService
    {
        User GetUser(int id);
        IEnumerable<User> GetAllUsers();
        void AddUser(User user);
        void UpdateUser(User user);
        void RemoveUser(int id);
    }
}
