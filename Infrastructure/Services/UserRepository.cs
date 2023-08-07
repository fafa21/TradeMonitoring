using ApplicationCore.Interface;
using Infrastructure;
using Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Services
{
    public class UserRepository : IUserRepository
    {
        protected readonly TradeMonitoringContext _tradeMonitoringContext;
        protected readonly DbSet<User> _dbSet;


        public UserRepository(TradeMonitoringContext tradeMonitoringContext, DbSet<User> dbSet)
        {
            _tradeMonitoringContext = tradeMonitoringContext;
            _dbSet = dbSet;
        }

        public IEnumerable<User> GetAll()
        {
            throw new NotImplementedException();
        }

        //public override async Task<IEnumerable<User>> GetAllAsync()
        //{
        //    return await _dbSet.ToListAsync();

        //}

        public Task Insert(User entity)
        {
            throw new NotImplementedException();
        }
    }
}
