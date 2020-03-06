using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceDesk.Domain.State
{
    public class ClosedState : IState
    {
        public string Description { get; } = "Закрыта";

        public void Handle(Request request)
        {
            throw new NotImplementedException();
        }
    }
}
