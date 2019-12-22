using System;
using System.Collections.Generic;

namespace Presentation
{
    public interface IAddUser : IView
    {
        event Action AddUser;

        string UserName { get; }
    }
}