using System.Collections.Generic;

namespace CounterApi.Core.Interfaces
{

    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity Get(int id);

        void Add(TEntity entity);
        void AddRange(IEnumerable<TEntity> entities);

        void Remove(TEntity entity);
        void RemoveRange(IEnumerable<TEntity> entities);

        void Update();
    }
}
