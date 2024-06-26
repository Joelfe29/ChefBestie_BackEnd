using ChefBestie.Domain;

namespace ChefBestie.Repositories.Inferfaces
{
    public interface IUserRepository
    {
        List<User> GetAll();
        User GetById(int id);
        List<User> GetByName(string name);
        User Add(User user);
        User Update(User user);
        void Remove(string user);
    }
}
