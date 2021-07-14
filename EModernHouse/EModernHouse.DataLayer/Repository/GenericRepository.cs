using EModernHouse.DataLayer.Entities.Common;
using System.Threading.Tasks;

namespace EModernHouse.DataLayer.Repository
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : BaseEntity
    {
        #region Ctor



        #endregion
        public ValueTask DisposeAsync()
        {
            throw new System.NotImplementedException();
        }
    }
}