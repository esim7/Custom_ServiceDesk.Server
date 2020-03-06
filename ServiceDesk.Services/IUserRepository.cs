using ServiceDesk.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceDesk.Services
{
    public interface IUserRepository
    {
        void Add();
        void Update();
        void Remove();
        ICollection<User> GetAll();
    }
}
