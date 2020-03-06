using ServiceDesk.DataAccess.Abstract;
using ServiceDesk.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceDesk.DataAccess
{
    public class MsSqlRequestRepository : IRequestRepository<Request>
    {
        private DeskContext Context;
        private bool Disposed = false;

        public MsSqlRequestRepository()
        {
            this.Context = new DeskContext();
        }

        public void Add(Request request)
        {
            throw new NotImplementedException();
        }


        public ICollection<Request> GetAll()
        {
            throw new NotImplementedException();
        }

        public Request GetRequest(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(Request request)
        {
            throw new NotImplementedException();
        }

        public virtual void Dispose(bool dispose)
        {
            if (!this.Disposed)
            {
                if (dispose)
                {
                    Context.Dispose();
                }
            }
            this.Disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

    }
}
