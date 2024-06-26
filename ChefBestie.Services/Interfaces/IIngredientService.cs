using ChefBestie.Domain;

namespace ChefBestie.Services.Interfaces
{
    public interface IIngredientService
    {
        List<Ingredient> GetAll();
        Ingredient GetById(int id);
        Ingredient Post(Ingredient ingredient);
        void RemoveById(int id);
    }
}
