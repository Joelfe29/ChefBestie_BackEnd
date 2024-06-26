using ChefBestie.Domain;
using ChefBestie.Repositories.Inferfaces;
using ChefBestie.Services.Interfaces;

namespace ChefBestie.Services.Implementation
{
    public class RecipeService : IRecipeService
    {
        private readonly IRecipeRepository _recipeRepository;

        public RecipeService(IRecipeRepository recipeRepository)
        {
            _recipeRepository = recipeRepository;
        }

        public List<Recipe> GetAll()
        {
            return _recipeRepository.GetAll();
        }

        public Recipe Post(Recipe recipe)
        {
            if (recipe == null)
            {
                return _recipeRepository.Add(recipe);
            }
            else 
            {
                return _recipeRepository.Update(recipe);
            }
        }     

        public void RemoveById(int id)
        {
            if (id != 0)
            {
                _recipeRepository.RemoveById(id);
            }
            else
            {
                throw new InvalidOperationException("Recipe not found.");
            }
            
        }

        public Recipe GetById(int id)
        {
            if (id != 0)
            {
                return _recipeRepository.GetById(id);
            }
            else
            {
                throw new InvalidOperationException("Recipe not found.");
            }
        }
            

        public List<Recipe> GetByCategory(string category)
        {
            if (category != null)
            {
                return _recipeRepository.GetByCategory(category);
            }
            else
            {
                throw new InvalidOperationException("Category not found.");
            }
            
        }

        public List<Recipe> GetByTitle(string title)
        {
            if (title != null)
            {
                return _recipeRepository.GetByTitle(title);
            }
            else
            {
                throw new InvalidOperationException("Title not found.");
            }
            
        }

        public List<Recipe> GetByDifficulty(string difficulty)
        {
            if (difficulty != null || difficulty == "fácil" || difficulty == "médio" || difficulty == "díficil")
            {
                return _recipeRepository.GetByDifficulty(difficulty);
            }
            else
            {
                throw new InvalidOperationException("Difficulty not found.");
            }
            
        }
        
        public List<Recipe> GetAllApproved()
        {
            
            return _recipeRepository.GetAllApproved();
        }

        //public List<Recipe> GetByIngredient(string ingredient)
        //{
        //    if (ingredient != null)
        //    {
        //        return _recipeRepository.GetByIngredient(ingredient);
        //    }
        //    else
        //    {
        //        throw new InvalidOperationException("Ingredient not found.");
        //    }

        //}
    }
}
