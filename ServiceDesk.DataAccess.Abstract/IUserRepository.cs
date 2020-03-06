using ServiceDesk.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceDesk.DataAccess.Abstract
{
    public interface IUserRepository<T> : IDisposable
        where T : class
    {
        void Add(User user);
        void Update(User user);
        void Remove(Guid id);
        User GetRequest(Guid id);
        ICollection<User> GetAll();
    }
}
