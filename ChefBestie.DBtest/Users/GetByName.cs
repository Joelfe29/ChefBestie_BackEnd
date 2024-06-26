using ChefBestie.Data.Context;
using ChefBestie.Domain;
using ChefBestie.Repositories.Inferfaces;
using ChefBestie.Repositories.Repos;

namespace ChefBestie.DBtest.Users
{
    public class GetByName
    {
        static void Main(string[] args)
        {

            ChefBestieDBContext chefBestieDBContext = new();

            IUserRepository userRepository = new UserRepository(chefBestieDBContext);

            List<User> user = userRepository.GetByName("Joel");

            user.ForEach(Console.Write);






        }
    }
}
