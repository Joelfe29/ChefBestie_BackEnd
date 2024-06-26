using ChefBestie.Data.Context;
using ChefBestie.Domain;
using ChefBestie.Repositories.Inferfaces;
using ChefBestie.Repositories.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChefBestie.DBtest.Users
{
    public class RemoveById
    {
        static void Main(string[] args)
        {
            
            ChefBestieDBContext chefBestieDBContext = new();

            IUserRepository userRepository = new UserRepository(chefBestieDBContext);

            userRepository.Remove("Nicolae");

            chefBestieDBContext.SaveChanges();
        }
    }
}
