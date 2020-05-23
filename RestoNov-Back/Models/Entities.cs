using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RestoNov_Back.Models
{
    public class Recette
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id {get;set;}
        public string Name { get; set; }

        public string Description { get; set; }

        public List<IngredientRecette> IngredientRecette { get; set; }
    }


    public class Ingredient
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string Name { get; set; }

        public string Description { get; set; }

        public List<IngredientRecette> IngredientRecette { get; set; }
    }

    public class IngredientRecette
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public Guid RecetteId { get; set; }

        public Guid IngredientId { get; set; }

        public Ingredient Ingredient {get;set;}

        public Recette Recette { get; set; }
    }
}
