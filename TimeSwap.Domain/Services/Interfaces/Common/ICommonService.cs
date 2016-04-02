using System.Collections.Generic;

namespace TimeSwap.Domain.Services.Interfaces.Common
{
   public interface ICommonService<TEntity> where TEntity : class
    {
        TEntity Find(int id);
        TEntity Single();
        IList<TEntity> All();

        TEntity Update(TEntity entity);
        void Add(TEntity entity);
        void Delete(TEntity entity);
    }
}
