using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace TimeSwap.Domain.Repositories.Common
{
    public interface IReadRepository<TEntity> where TEntity : class, new()
    {
        TEntity Find(int id);
        TEntity First();

        TEntity Single(Expression<Func<TEntity, bool>> condition);
        TEntity Single(List<Expression<Func<TEntity, bool>>> conditions);

        IList<TEntity> Many(Expression<Func<TEntity, bool>> condition);
        IList<TEntity> Many(List<Expression<Func<TEntity, bool>>> conditions);

        IList<TEntity> All();
    }
}
