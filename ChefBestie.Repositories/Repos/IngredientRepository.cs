using ChefBestie.Data.Context;
using ChefBestie.Domain;
using ChefBestie.Repositories.Inferfaces;
using Microsoft.EntityFrameworkCore;

namespace ChefBestie.Repositories.Implementations
{
    public class IngredientRepository : IIngredientRepository
    {
        private readonly DbSet<Ingredient> _dbSet;
        private readonly ChefBestieDBContext _chefBestieDBContext;
        public IngredientRepository(ChefBestieDBContext chefBestieDBContext)
        {
            _dbSet = chefBestieDBContext.Set<Ingredient>();
            _chefBestieDBContext = chefBestieDBContext;
        }

        public List<Ingredient> GetAll()
        {
            return _dbSet.ToList();
        }

        public Ingredient GetById(int id)
        {
            return _dbSet.FirstOrDefault(p => p.Id == id);
        }

        public Ingredient Add(Ingredient ingredient)
        {
            _dbSet.Add(ingredient);
            _chefBestieDBContext.SaveChanges();
            return ingredient;
        }


        public Ingredient Update(Ingredient ingredient)
        {
            _dbSet.Update(ingredient);
            _chefBestieDBContext.SaveChanges();
            return ingredient;
        }

        public void RemoveById(int id)
        {
            Ingredient ingredientToRemove = _dbSet.FirstOrDefault(p => p.Id == id);
            _dbSet.Remove(ingredientToRemove);
            _chefBestieDBContext.SaveChanges();
        }
    }
}