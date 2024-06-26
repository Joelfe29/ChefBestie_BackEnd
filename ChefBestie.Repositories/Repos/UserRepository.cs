using ChefBestie.Data.Context;
using ChefBestie.Domain;
using ChefBestie.Repositories.Inferfaces;
using Microsoft.EntityFrameworkCore;

namespace ChefBestie.Repositories.Repos
{
    public class UserRepository : IUserRepository
    {
        private readonly DbSet<User> _dbSet;
        private readonly ChefBestieDBContext _chefBestieDBContext;
        public UserRepository(ChefBestieDBContext chefBestieDBContext)
        {
            _dbSet = chefBestieDBContext.Set<User>();
            _chefBestieDBContext = chefBestieDBContext;
        }
        public List<User> GetAll()
        {
            return _dbSet.ToList();
        }

        public User GetById(int id)
        {
            return _dbSet.FirstOrDefault(p => p.Id == id);
        }

        public List<User> GetByName(string name)
        {
            return _dbSet.Where
                (p => p.FirstName.Contains(name)
                 ||
                 p.LastName.Contains(name)).ToList();

        }

        public User Add(User user)
        {
            _dbSet.Add(user);
            _chefBestieDBContext.SaveChanges();
            return user;
        }

        public User Update(User user)
        {
            _dbSet.Update(user);
            _chefBestieDBContext.SaveChanges();
            return user;
        }

        public void Remove(string user)
        {
            User name = _dbSet.FirstOrDefault(p => p.FirstName == user);
            _dbSet.Remove(name);
            _chefBestieDBContext.SaveChanges();

        }
    }
}
