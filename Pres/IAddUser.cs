using System;
using System.Collections.Generic;

namespace Pres
{
    public interface IAddUser : IView
    {
        event Action AddUser;

        string UserName { get; }
    }
}