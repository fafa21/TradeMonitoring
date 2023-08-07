using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IUnitOfWork<out TContext> where TContext : DbContext, new()
    {
        TContext Current { get; }
        void Commit();
        void Rollback();
        void Save();
        void CreateTransaction();
        //void UpdateTransaction();
        //void DeleteTransaction();
        //void DeleteAll();

    }
}
