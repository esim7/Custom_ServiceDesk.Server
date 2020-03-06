using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceDesk.Domain
{
    public class Worker : User, IRequestExecutor
    {
        public List<Request> Requests { get; set; }
        public void ExecuteRequest()
        {
            throw new NotImplementedException();
        }
    }
}
