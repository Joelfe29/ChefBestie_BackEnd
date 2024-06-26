using ChefBestie.Domain;
using ChefBestie.Repositories.Implementations;
using ChefBestie.Repositories.Inferfaces;
using ChefBestie.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ChefBestie.Services.Implementation
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;

        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public List<User> GetAll()
        { 
            return _userRepository.GetAll(); 
        }

        public User GetById(int id)
        {
            if (id != 0)
            {
                return _userRepository.GetById(id);
            }
            else
            {
                throw new InvalidOperationException("User not found.");
            }
            
        }

        public List<User> GetByName(string name)
        {
            return _userRepository.GetByName(name);
        }

        public User Post(User user)
        {
            if (user == null)
            {
                return _userRepository.Add(user);
            }
            else
            {
                return _userRepository.Update(user);
            }
        }
 
        public void Remove(string name) 
        {
            if (name != null)
            {
                _userRepository.Remove(name);
            }
            else
            {
                throw new InvalidOperationException("User not found.");
            }
            
        }



    }
}
