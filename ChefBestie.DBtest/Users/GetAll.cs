using ChefBestie.Data.Context;
using ChefBestie.Domain;
using ChefBestie.Repositories.Inferfaces;
using ChefBestie.Repositories.Repos;

namespace ChefBestie.DBtest.Users
{
    public class GetAll
    {
        static void Main(string[] args)
        {

            ChefBestieDBContext chefBestieDBContext = new();

            IUserRepository userRepository = new UserRepository(chefBestieDBContext);

            List<User> user = userRepository.GetAll();

            user.ForEach(Console.Write);


        }
    }
}
