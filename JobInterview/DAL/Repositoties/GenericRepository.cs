using DAL.Context;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositoties
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private readonly JobInterviewContext context;
        private DbSet<TEntity> entities;

        public GenericRepository(JobInterviewContext jobInterviewContext)
        {
            context = jobInterviewContext;
            entities = context.Set<TEntity>();
        }

        public IQueryable<TEntity> GetAll()
        {
            return entities;
        }

        public virtual async Task<List<TEntity>> GetAllAsync()
        {
            return await context.Set<TEntity>().AsNoTracking().ToListAsync();
        }

        public TEntity Get(int id)
        {
            return entities.Find(id);
        }
        public virtual async Task<TEntity> GetAsync(int id)
        {
            return await entities.FindAsync(id);
        }

        public TEntity Create(TEntity entity)
        {
            entities.Add(entity);
            return entity;
        }

        public async Task<TEntity> CreateAsync(TEntity entity)
        {
            context.Set<TEntity>().Add(entity);
            await context.SaveChangesAsync();

            return entity;
        }

        public TEntity Update(TEntity entity)
        {
            if (entity == null)
                return null;

            entities.AddOrUpdate(entity);
            return entity;
        }

        public async Task UpdateAsync(TEntity entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            await context.SaveChangesAsync();
        }

        public void Delete(int id)
        {
            TEntity entity = entities.Find(id);

            if (entity != null)
                entities.Remove(entity);
        }

        public virtual async Task DeleteAsync(int id)
        {
            TEntity entity = entities.Find(id);
            context.Set<TEntity>().Remove(entity);
            await context.SaveChangesAsync();
        }

        public IEnumerable<TEntity> Find(Func<TEntity, bool> predicate)
        {
            return entities.Where(predicate);
        }
    }
}
