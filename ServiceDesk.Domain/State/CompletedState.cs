using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceDesk.Domain.State
{
    public class CompletedState : IState
    {
        public string Description { get; } = "Исполнена";

        public void Handle(Request request)
        {
            throw new NotImplementedException();
        }
    }
}
