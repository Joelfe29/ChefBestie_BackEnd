using ChefBestie.Domain;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace ChefBestie.Data.Context
{
    public class ChefBestieDBContext : DbContext
    {

        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server = localhost; database = ChefBestieDataB; integrated security = true; TrustServerCertificate = Yes;");
        }        
        
    }        
}
