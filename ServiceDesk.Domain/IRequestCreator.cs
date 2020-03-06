using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceDesk.Domain
{
    public interface IRequestCreator
    {
        Request CreateRequest();
    }
}
