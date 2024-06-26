using ChefBestie.Data.Context;
using ChefBestie.Domain;
using ChefBestie.Repositories.Inferfaces;
using Microsoft.EntityFrameworkCore;

namespace ChefBestie.Repositories.Repos
{
    public class RecipeRepository : IRecipeRepository
    {

        private readonly DbSet<Recipe> _dbSet;
        private readonly ChefBestieDBContext _chefBestieDBContext;
        public RecipeRepository(ChefBestieDBContext chefBestieDBContext)
        {
            _dbSet = chefBestieDBContext.Set<Recipe>();
            _chefBestieDBContext = chefBestieDBContext;
        }

        public List<Recipe> GetAll()
        {
            return _chefBestieDBContext.Recipes.Include(r => r.Ingredients).ToList();
        }

        public Recipe GetById(int id)
        {
            return _dbSet.Include(r => r.Ingredients).FirstOrDefault(p => p.Id == id);
        }

        public Recipe Add(Recipe recipe)
        {
            _dbSet.Add(recipe);
            _chefBestieDBContext.SaveChanges();
            return recipe;
        }


        public Recipe Update(Recipe recipe)
        {
            _dbSet.Update(recipe);
            _chefBestieDBContext.SaveChanges();
            return recipe;
        }

        public void RemoveById(int id)
        {
            Recipe recipeToRemove = _dbSet.Include(r => r.Ingredients).FirstOrDefault(p => p.Id == id);
            _dbSet.Remove(recipeToRemove);
            _chefBestieDBContext.SaveChanges();
        }

        public List<Recipe> GetByCategory(string category)
        {
            return _dbSet.Where(p => p.Category.ToLower().Contains(category.ToLower())).ToList();
        }

        public List<Recipe> GetByTitle(string title)
        {
            return _dbSet.Where(p => p.Title.ToLower().Contains(title.ToLower())).ToList();
        }


        public List<Recipe> GetByDifficulty(string difficulty)
        {
            return _dbSet.Where(p => p.Difficulty.ToLower() == difficulty.ToLower()).ToList();
        }
       
        public List<Recipe> GetAllApproved()
        {
            return _dbSet.Where(p => p.IsApproved == true).ToList();
        }

        //public List<Recipe> GetByIngredient(string ingredient)
        //{
        //    List<Recipe> toReturn = new();

        //    RecipeRepository repo = new RecipeRepository(_chefBestieDBContext);

        //    foreach (Recipe recipe in repo.GetAllApproved())
        //    {
        //        foreach (Ingredient ingred in recipe.Ingredients)
        //        {
        //            if (ingred.Name == ingredient) toReturn.Add(recipe);
        //        }
        //    }

        //    return toReturn;
        //}


        //public List<Recipe> GetTopRecipes(int top)
        //{
        //    return _dbSet.Include(x => x.Ingredients)
        //        .OrderByDescending(x => x.Title)
        //        .Take(top)
        //        .ToList();
        //}
    }
}
