using ApplicationCore.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore
{
    public class Repository<T> : IRepository<T> where T : class
    {
        protected DbContext _db;
        protected DbSet<T> _dbSet;
        public Repository(DbContext DB, DbSet<T> dbSet)
        {
            _db = DB;
            _dbSet = dbSet;
        }

        //public void Add(T entity)
        //{
        //    throw new NotImplementedException();
        //}

        public virtual async Task<IEnumerable<T>> GetAllAsync()
        {
            return await _dbSet.ToListAsync();

        }

        public virtual async Task<T> AddAsync(T entities)
        {
            try
            {
                await _dbSet.AddAsync(entities);
                _db.SaveChanges();
                return entities;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public virtual async Task<IEnumerable<T>> AddRangeAsync(IEnumerable<T> entities)
        {
            try
            {
                await _dbSet.AddRangeAsync(entities);
                //_db.SaveChanges();
                return entities;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public virtual async Task<bool> DeleteAsync(T entity)
        {
            try
            {
                _dbSet.Remove(entity);
                _db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                throw;
            }
        }

        public virtual Task<IEnumerable<T>> DeleteRangeAsync(IEnumerable<T> entites)
        {
            throw new NotImplementedException();
        }

        public virtual Task<int> SaveChangeAsync()
        {
            throw new NotImplementedException();
        }

        public virtual Task<T> UpdateAsync(T entity)
        {
            _dbSet.Update(entity);
            //_db.SaveChanges();
            return Task.FromResult(entity);
        }

        public virtual Task<IEnumerable<T>> UpdateRangeAsync(IEnumerable<T> entities)
        {
            throw new NotImplementedException();
        }


    }
}
