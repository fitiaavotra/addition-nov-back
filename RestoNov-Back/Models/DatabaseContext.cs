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
    }
}
