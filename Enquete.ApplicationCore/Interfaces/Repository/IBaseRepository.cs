﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Enquete.ApplicationCore.Interfaces.Repository
{
    public interface IBaseRepository<TEntity> where TEntity : class
    {
        TEntity Add(TEntity entity);
        void Update(TEntity entity);
        IEnumerable<TEntity> GetAll();
        TEntity GetById(int id);
        IEnumerable<TEntity> Get(Expression<Func<TEntity, bool>> predicate);
        void Remove(TEntity entity);
        void BeginTransaction();
        void Commit();
        void Rollback();
    }
}
