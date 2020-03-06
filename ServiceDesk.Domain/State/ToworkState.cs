using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceDesk.Domain.State
{
    public class ToworkState : IState
    {
        public string Description { get; } = "Принята в работу";

        public void Handle(Request request)
        {
            throw new NotImplementedException();
        }
    }
}
