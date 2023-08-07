using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;

namespace Repository
{
    public class UnitOfWork<TContext> : IUnitOfWork<TContext>, IDisposable where TContext : DbContext, new()
    {
        private TContext _context;
        private bool _disposed;
        private string _erroMessage = string.Empty;
        private IDbContextTransaction _objtran;
        private Dictionary<string, object> _repositories;

        public UnitOfWork(TContext context)
        {
            _context = context;
        }

        public TContext Current => _context;

        public void Commit()
        {
            _objtran.Commit();
        }

        public void CreateTransaction()
        {
            _objtran = _context.Database.BeginTransaction();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!_disposed)
                if (disposing)
                    _context.Dispose();
            disposing = true;

        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);

        }

        public void Rollback()
        {

            _objtran.Rollback();
            _objtran.Dispose();
        }

        public void Save()
        {
            try
            {
                _context.SaveChanges();
            }
            catch (Exception/*DbEntityValidationException*/ dbEx)
            {
                //foreach (var validationErrors in dbEx.EntityValidationErrors)
                //    foreach (var validationError in validationErrors.ValidationErrors)
                //        _errorMessage += string.Format("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage) + Environment.NewLine;
                //throw new Exception(_errorMessage, dbEx);
            }
        }


    }
}

