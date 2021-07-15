using System;
using System.Linq;
using System.Threading.Tasks;
using EModernHouse.DataLayer.Entities.Common;

namespace EModernHouse.DataLayer.Repository
{
    public interface IGenericRepository<TEntity> : IAsyncDisposable where TEntity : BaseEntity
    {

        IQueryable<TEntity> GetQuery();
        Task<TEntity> GetEntityById(long entityId);
        Task AddEntity(TEntity entity);
        void EditEntity(TEntity entity);
        void DeleteEntity(TEntity entity);
        Task DeleteEntity(long entityId);
        void DeletePermanent(TEntity entity);
        Task DeletePermanent(long entityId);
        Task SaveChanges();
    }
}