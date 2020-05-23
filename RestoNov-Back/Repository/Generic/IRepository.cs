using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace RestoNov_Back.Repository
{
    public interface IRepository<TEntity>
    where TEntity : class
    {
        IQueryable<TEntity> GetAll();

        Task<TEntity> GetById(Guid id);

        Task Create(TEntity entity);

        Task Update(int id, TEntity entity);

        Task Delete(Guid id);
    }
}
