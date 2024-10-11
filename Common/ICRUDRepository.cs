using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public interface ICRUDRepository<TEntity,TId>
    {
        IEnumerable<TEntity> Get();

        TEntity Get(TId id);

        TId Insert(TEntity entity);

        void update(TId id,TEntity entity);

        void delete(TId id);

    }
}
