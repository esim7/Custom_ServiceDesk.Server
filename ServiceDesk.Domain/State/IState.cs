using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceDesk.Domain.State
{
    public interface IState
    {
        public string Description { get; }
        void Handle(Request request);
    }
}
