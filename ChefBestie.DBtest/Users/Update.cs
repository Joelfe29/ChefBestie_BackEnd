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
    public class Update
    {
        static void Main(string[] args)
        {
            User user = new()
            {
                Id = 3,
                Admin = false,
                FirstName = "Nicolae",
                LastName = "Massas",
                Email = "engenheiro@gmail.com",
                Password = "1234567890"
            };



            ChefBestieDBContext chefBestieDBContext = new();

            IUserRepository userRepository = new UserRepository(chefBestieDBContext);

            userRepository.Update(user);

            chefBestieDBContext.SaveChanges();
        }
    }
}
