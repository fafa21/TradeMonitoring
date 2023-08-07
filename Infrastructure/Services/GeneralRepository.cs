using ApplicationCore.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Services
{
    public class GeneralRepository<TEntity, Tkey> : IGeneralRepository<TEntity, Tkey>
        where TEntity : class//, IEntity<Tkey>
    {
        private readonly DbContext dbContext;

        public GeneralRepository(DbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public IEnumerable<TEntity> GetAll()
        {
            return dbContext.Set<TEntity>().ToList();
        }
        public async Task Insert(TEntity entity)
        {
            await dbContext.Set<TEntity>().AddAsync(entity);
            await dbContext.SaveChangesAsync();
        }
    }
}
