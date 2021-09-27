using System;
using System.Collections.Generic;
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
        Task AddRangeEntity(List<TEntity> entities);
        void EditEntity(TEntity entity);
        void DeleteEntity(TEntity entity);
        Task DeleteEntity(long entityId);
        void DeletePermanent(TEntity entity);
        void DeletePermanentRange(List<TEntity> entities);
        void Delete(TEntity entity);
        Task DeletePermanent(long entityId);
        Task SaveChanges();
    }
}