using ChefBestie.Data.Context;
using ChefBestie.Domain;
using ChefBestie.Repositories.Inferfaces;
using ChefBestie.Repositories.Repos;

namespace ChefBestie.DBtest.Users
{
    public class Add
    {
        static void Main(string[] args)
        {
            User user = new()
            {
                Admin = false,
                FirstName = "Cátia",
                LastName = "Princess",
                Email = "princess@gmail.com",
                Password = "linda"
            };



            ChefBestieDBContext chefBestieDBContext = new();

            IUserRepository userRepository = new UserRepository(chefBestieDBContext);

            userRepository.Add(user);

            chefBestieDBContext.SaveChanges();
        }
    }
}