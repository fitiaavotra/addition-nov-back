using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestoNov_Back.Models
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options) { }
        public DbSet<Recette> Recettes { get; set; }

        public DbSet<Ingredient> Ingredients { get; set; }

        public DbSet<IngredientRecette> IngredientRecettes { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            var Recette = new List<Recette>();


            var Ingredient = new List<Ingredient>();

            
            var IngredientRecette = new List<IngredientRecette>();


            Initialiser.SetValue(Recette, Ingredient, IngredientRecette);

            modelBuilder.Entity<Recette>().HasData(Recette);
            modelBuilder.Entity<Ingredient>().HasData(Ingredient);
            modelBuilder.Entity<IngredientRecette>().HasData(IngredientRecette);



        }
    }
}
