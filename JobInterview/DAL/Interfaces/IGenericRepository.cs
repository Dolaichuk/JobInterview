using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        IQueryable<TEntity> GetAll();
        Task<List<TEntity>> GetAllAsync();
        TEntity Get(int Id);
        Task<TEntity> GetAsync(int id);
        TEntity Create(TEntity entity);
        Task<TEntity> CreateAsync(TEntity entity);
        TEntity Update(TEntity entity);
        Task UpdateAsync(TEntity entity);
        void Delete(int id);
        Task DeleteAsync(int id);

        IEnumerable<TEntity> Find(Func<TEntity, bool> predicate);
    }
}
