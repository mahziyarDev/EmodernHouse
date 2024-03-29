﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using EModernHouse.DataLayer.Entities.Common;
using System.Threading.Tasks;
using EModernHouse.DataLayer.Context;
using Microsoft.EntityFrameworkCore;

namespace EModernHouse.DataLayer.Repository
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : BaseEntity
    {
        #region Ctor

        private readonly EModernHouseDbContext _context;
        private readonly DbSet<TEntity> _dbSet;

        public GenericRepository(EModernHouseDbContext context)
        {
            _context = context;
            this._dbSet = context.Set<TEntity>();
        }

        #endregion

      

        public IQueryable<TEntity> GetQuery()
        {
            return _dbSet.AsQueryable();
        }

        public async Task<TEntity> GetEntityById(long entityId)
        {
            return await _dbSet.SingleOrDefaultAsync(s => s.Id == entityId);
        }

        public async Task AddEntity(TEntity entity)
        {
            entity.CreateDate = DateTime.Now;
            entity.LastUpdateDate = DateTime.Now;
            await _dbSet.AddAsync(entity);
        }

        public async Task AddRangeEntity(List<TEntity> entities)
        {
            foreach (var entity in entities)
            {
                await AddEntity(entity);
            }
        }

        public void EditEntity(TEntity entity)
        {
            entity.LastUpdateDate = DateTime.Now;
            _dbSet.Update(entity);
        }

        public void DeleteEntity(TEntity entity)
        {
            entity.IsDelete = true;
            EditEntity(entity);
        }

        public async Task DeleteEntity(long entityId)
        {
            TEntity entity = await GetEntityById(entityId);
            if (entity != null)
            {
                DeleteEntity(entity);
            }
        }

        public void DeletePermanent(TEntity entity)
        {
            _dbSet.Remove(entity);
        }

        public void DeletePermanentRange(List<TEntity> entities)
        {
            _context.RemoveRange(entities);
        }
        public async Task DeletePermanent(long entityId)
        {
            TEntity entity = await GetEntityById(entityId);
            if (entity != null)
            {
                DeletePermanent(entity);
            }

        }

        public void Delete(TEntity entity)
        {
            _context.Remove(entity);
        }
        public async Task SaveChanges()
        {
            await _context.SaveChangesAsync();
        }

        #region Disposable

        public async ValueTask DisposeAsync()
        {
            if (_context != null)
            {
                await _context.DisposeAsync();
            }
        }

        #endregion
    }
}