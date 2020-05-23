using Microsoft.EntityFrameworkCore.Query.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestoNov_Back.Models
{
    public static class Initialiser
    {
        public static string[] ingredientSalade = { "laitue", "tomate", "fromage", "pain complet", };
        public static string[] ingredientSoupe = { "pomme de terre", "carotte", "crevette" };
        public static string[] ingredientPizza = { "fromage", "crème fraîche", "crevette", "thon" };




        public  static void SetValue (List<Recette> recette,List<Ingredient> ingredient,List<IngredientRecette> IngredientRecette) 
        {


            recette.Add(new Recette()
            {
                Id = Guid.NewGuid(),
                Name = "Salade"
            });
            recette.Add(new Recette()
            {
                Id = Guid.NewGuid(),
                Name = "Soupe"
            });
            recette.Add(new Recette()
            {
                Id = Guid.NewGuid(),
                Name = "Pizza"
            });

            ingredient.Add(new Ingredient()
            {
                Id = Guid.NewGuid(),
                Name = "laitue"
            });
            ingredient.Add(new Ingredient()
            {
                Id = Guid.NewGuid(),
                Name = "tomate"
            });
            ingredient.Add(new Ingredient()
            {
                Id = Guid.NewGuid(),
                Name = "fromage"
            });
            ingredient.Add(new Ingredient()
            {
                Id = Guid.NewGuid(),
                Name = "pain complet"
            });
            ingredient.Add(new Ingredient()
            {
                Id = Guid.NewGuid(),
                Name = "pomme de terre"
            });
            ingredient.Add(new Ingredient()
            {
                Id = Guid.NewGuid(),
                Name = "carotte"
            });
            ingredient.Add(new Ingredient()
            {
                Id = Guid.NewGuid(),
                Name = "crevette"
            });
            ingredient.Add(new Ingredient()
            {
                Id = Guid.NewGuid(),
                Name = "crème fraîche"
            });
            ingredient.Add(new Ingredient()
            {
                Id = Guid.NewGuid(),
                Name = "thon"

            });

            var Recettevalue = recette.First(d => d.Name == "Pizza");

            foreach (var item in ingredient.Where(i => ingredientPizza.Any(i.Name.Contains)))
            {
                IngredientRecette.Add(new IngredientRecette { Id = Guid.NewGuid(), IngredientId = item.Id, RecetteId = Recettevalue.Id });
            }

            Recettevalue = recette.First(d => d.Name == "Soupe");

            foreach (var item in ingredient.Where(i => ingredientPizza.Any(i.Name.Contains)))
            {
                IngredientRecette.Add(new IngredientRecette { Id = Guid.NewGuid(), IngredientId = item.Id, RecetteId = Recettevalue.Id });
            }

            Recettevalue = recette.First(d => d.Name == "Salade");

            foreach (var item in ingredient.Where(i => ingredientSalade.Any(i.Name.Contains)))
            {
                IngredientRecette.Add(new IngredientRecette { Id = Guid.NewGuid(), IngredientId = item.Id, RecetteId = Recettevalue.Id });
            }


        }

    }
}
