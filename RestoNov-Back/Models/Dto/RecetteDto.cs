using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestoNov_Back.Models
{
    public class RecetteDto:Recette
    {
        public List <Ingredient> ingredients { get; set; }
    }
}
