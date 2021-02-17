using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly La3bniContext la3BniContext;

        public Repository(La3bniContext _la3BniContext)
        {
            la3BniContext = _la3BniContext;
        }

        public int Add(TEntity entity)
        {
            la3BniContext.Set<TEntity>().Add(entity);
            return SaveChanges();
        }

        public int AddRange(List<TEntity> entities)
        {
            la3BniContext.Set<TEntity>().AddRange(entities);
            return SaveChanges();
        }

        public int Delete(TEntity entity)
        {
            la3BniContext.Entry(entity).State = EntityState.Deleted;
            return SaveChanges();
        }

        public async Task<TEntity> Find(Expression<Func<TEntity, bool>> wherePredict)
        {
            return await la3BniContext.Set<TEntity>().FirstOrDefaultAsync(wherePredict);
        }

        public async Task<List<TEntity>> GetAll()
        {
            return await la3BniContext.Set<TEntity>().ToListAsync();
        }

        public int SaveChanges()
        {
            return la3BniContext.SaveChanges();
        }
    }
}