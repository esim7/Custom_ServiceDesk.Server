using ServiceDesk.Domain;
using System;
using System.Collections.Generic;

namespace ServiceDesk.DataAccess.Abstract
{
    public interface IRequestRepository<T> : IDisposable
        where T : class
    {
        void Add(Request request);
        void Update(Request request);
        void Remove(Guid id);
        Request GetRequest(Guid id);
        ICollection<Request> GetAll();
    }
}
