using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.contracts
{
    public interface IReposatory<TEntity,Tid> where TEntity : class
    {
        Task< TEntity?> GetByIDAsync(Tid id);
        Task<TEntity> createAsync(TEntity entity);
        Task<bool> updateAsync(TEntity entity);
        Task<bool> deleteAsync(Tid id);
        Task<int> savechangesAsync();
    }
}
