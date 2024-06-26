

using ChefBestie.Domain;

namespace ChefBestie.Repositories.Inferfaces
{
    public interface IIngredientRepository
    {
        List<Ingredient> GetAll();
        Ingredient GetById(int id);
        Ingredient Add(Ingredient ingredient);
        Ingredient Update(Ingredient ingredient);
        void RemoveById(int id);


    }
}
