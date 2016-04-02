namespace TimeSwap.Domain.Repositories.Common
{
    public interface IAddRepository<TEntity> where TEntity:class,new()
    {
        void Add(TEntity entity);
    }
}
