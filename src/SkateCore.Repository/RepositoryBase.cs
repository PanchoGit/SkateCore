using Microsoft.EntityFrameworkCore;
using SkateCore.Repository.Interfaces;
using SkateCore.Repository.Extensions;

namespace SkateCore.Repository
{
    public abstract class RepositoryBase<TEntity, TId> : IRepository<TEntity, TId> where TEntity : class
    {
        protected DbSet<TEntity> set;
        protected DbContext context;

        public RepositoryBase(DbContext dbContext)
        {
            context = dbContext;
            set = dbContext.Set<TEntity>();
        }

        public TEntity Get(TId id)
        {
            return set.Find(id);
        }

        public TEntity Save(TEntity entity)
        {
            var result = set.Add(entity);

            context.SaveChanges();

            return result.Entity;
        }

        public void Delete(TId id)
        {
            set.Remove(set.Find(id));

            context.SaveChanges();
        }

        private TEntity Update(TEntity entity)
        {
            var result = set.Attach(entity);

            context.Entry(entity).State = EntityState.Modified;

            return result.Entity;
        }
    }
}
