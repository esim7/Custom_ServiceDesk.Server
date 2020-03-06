using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceDesk.Domain.State
{
    public class EmptyState : IState
    {
        public string Description { get; } = string.Empty;

        public void Handle(Request request)
        {
            throw new NotImplementedException();
        }
    }
}
