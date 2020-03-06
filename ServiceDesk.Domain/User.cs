using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceDesk.Domain
{
    public abstract class User : Entity
    {
        string Login { get; set; }
        string Password { get; set; }
        string Fullname { get; set; }
        string Position { get; set; }
        bool IsEntered { get; set; } = false;
    }
}
