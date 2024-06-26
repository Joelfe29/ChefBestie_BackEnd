using ChefBestie.Domain;

namespace ChefBestie.Services.Interfaces
{
    public interface IRecipeService
    {
        List<Recipe> GetAll();
        Recipe GetById(int id);
        Recipe Post(Recipe recipe);
        void RemoveById(int id);

        List<Recipe> GetByCategory(string category);
        List<Recipe> GetByTitle(string title);
        List<Recipe> GetByDifficulty(string difficulty);        
        List<Recipe> GetAllApproved();

        //List<Recipe> GetByIngredient(string ingredient);

    }
}
