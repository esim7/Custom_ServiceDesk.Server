using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceDesk.Domain.State
{
    public class CreatedState : IState
    {
        public string Description { get; } = "Создана";

        public void Handle(Request request)
        {
            throw new NotImplementedException();
        }
    }
}
