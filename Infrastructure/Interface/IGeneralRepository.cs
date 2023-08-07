using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Interface
{
    public interface IGeneralRepository<TEntity, Tkey> where TEntity : class//,  IEntity<Tkey> 
    {
        IEnumerable<TEntity> GetAll();
        Task Insert(TEntity entity);
    }
}
