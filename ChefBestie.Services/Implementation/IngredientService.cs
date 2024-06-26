using ChefBestie.Domain;
using ChefBestie.Repositories.Implementations;
using ChefBestie.Repositories.Inferfaces;
using ChefBestie.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ChefBestie.Services.Implementation
{
    public class IngredientService : IIngredientService
    {
        private readonly IIngredientRepository _ingredientRepository;

        public IngredientService(IIngredientRepository ingredientRepository)
        {
            _ingredientRepository = ingredientRepository;
        }

        public List<Ingredient> GetAll()
        {
            return _ingredientRepository.GetAll();
        }

        public Ingredient GetById(int id)
        {
            if (id != 0)
            {
                return _ingredientRepository.GetById(id);
            }
            else
            {
                throw new InvalidOperationException("Ingredient not found.");
            }
            
        }
        
        public Ingredient Post(Ingredient ingredient)
        {
            if (ingredient == null)
            {
                return _ingredientRepository.Add(ingredient);
            }
            else
            {
                return _ingredientRepository.Update(ingredient);
            }
        }
        

        public void RemoveById(int id)
        {
            if (id != 0)
            {
                _ingredientRepository.RemoveById(id);
            }
            else
            {
                throw new InvalidOperationException("ingredient not found.");
            }
            
        }
    }
}
