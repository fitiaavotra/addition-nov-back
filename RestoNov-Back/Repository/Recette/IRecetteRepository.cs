﻿using RestoNov_Back.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestoNov_Back.Repository.Recette
{
    public interface IRecetteRepository:IRepository<Models.Recette>
    
    {
        public List<Ingredient> GetIngredient(Guid IdRecette);
    }
}
