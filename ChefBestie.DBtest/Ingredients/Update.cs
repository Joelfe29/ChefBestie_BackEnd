using ChefBestie.Data.Context;
using ChefBestie.Domain;
using ChefBestie.Repositories.Implementations;
using ChefBestie.Repositories.Inferfaces;

namespace ChefBestie.DBtest.Ingredients
{
    public class Update
    {
        static void Main(string[] args)
        {
            Ingredient ingredient = new()
            {
                Id = 1,
                Name = "Bacalhau cozido e desfiado",
                Quantity = "1KG"
            };



            ChefBestieDBContext chefBestieDBContext = new();

            IIngredientRepository ingredientRepository = new IngredientRepository(chefBestieDBContext);

            ingredientRepository.Update(ingredient);

            chefBestieDBContext.SaveChanges();
        }
    }
}
