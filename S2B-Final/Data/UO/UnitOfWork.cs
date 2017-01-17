using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using S2B_Final.Context;

namespace S2B_Final.Data.UO
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DatabaseContext _wrContext;

        public UnitOfWork()
        {
            _wrContext = new DatabaseContext();
        }

        public void Save()
        {
            _wrContext.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _wrContext.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public DatabaseContext Context
        {
            get { return _wrContext; }
        }

    }
}