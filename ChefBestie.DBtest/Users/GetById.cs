using ChefBestie.Data.Context;
using ChefBestie.Domain;
using ChefBestie.Repositories.Inferfaces;
using ChefBestie.Repositories.Repos;

namespace ChefBestie.DBtest.Users
{
    public class GetById
    {
        static void Main(string[] args)
        {

            ChefBestieDBContext chefBestieDBContext = new();

            IUserRepository userRepository = new UserRepository(chefBestieDBContext);

            User user = userRepository.GetById(3);

            Console.Write(user);

        }
    }
}