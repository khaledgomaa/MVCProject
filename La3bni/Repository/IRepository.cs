﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IRepository<TEntity> where TEntity : class
    {
        public Task<List<TEntity>> GetAll();

        public Task<TEntity> Find(Expression<Func<TEntity, bool>> wherePredict);

        public void Add(TEntity entity);

        public void AddRange(List<TEntity> entities);

        public void Delete(TEntity entity);

        public void Update(TEntity entityToUpdate);
    }
}