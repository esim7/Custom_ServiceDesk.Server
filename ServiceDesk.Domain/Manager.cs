using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceDesk.Domain
{
    public class Manager : User, IRequestCreator
    {
        public Request Request;
        public Request CreateRequest()
        {
            throw new NotImplementedException();
        }
    }
}
