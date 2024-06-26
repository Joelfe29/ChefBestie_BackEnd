using ChefBestie.Domain;

namespace ChefBestie.Services.Interfaces
{
    public interface IUserService
    {
        List<User> GetAll();
        User GetById(int id);
        List<User> GetByName(string name);
        User Post(User user);
        void Remove(string user);
    }
}
