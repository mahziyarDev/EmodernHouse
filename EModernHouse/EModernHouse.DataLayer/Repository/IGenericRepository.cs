using System;
using EModernHouse.DataLayer.Entities.Common;

namespace EModernHouse.DataLayer.Repository
{
    public interface IGenericRepository<TEntity> : IAsyncDisposable where TEntity : BaseEntity
    {
        
    }
}