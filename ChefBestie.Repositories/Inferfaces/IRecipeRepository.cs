using ChefBestie.Domain;

namespace ChefBestie.Repositories.Inferfaces
{
    public interface IRecipeRepository
    {
        List<Recipe> GetAll();
        Recipe GetById(int id);
        Recipe Add(Recipe recipe);
        Recipe Update(Recipe recipe);
        void RemoveById(int id);

        List<Recipe> GetByCategory(string category);
        List<Recipe> GetByTitle(string title);
        List<Recipe> GetByDifficulty(string difficulty);        
        List<Recipe> GetAllApproved();

        //List<Recipe> GetByIngredient(string ingredient);

    }
}
