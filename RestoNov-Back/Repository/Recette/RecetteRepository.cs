using RestoNov_Back.Models;
using RestoNov_Back.Repository;
using RestoNov_Back.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestoNov_Back.Repository.Generic;

namespace RestoNov_Back.Repository.Recette
{
    public class RecetteRepository : Repository<Models.Recette>,IRecetteRepository
    {
        public RecetteRepository(DatabaseContext dbContext)
        : base(dbContext)
        {

        }
    }
}
