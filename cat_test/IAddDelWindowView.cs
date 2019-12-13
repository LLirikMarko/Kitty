using System;
using System.Collections.Generic;

namespace Presentation
{
    public interface IAddInitiativeView : IView
    {
        string UserName { get; }

        event Action AddInitiative;

        void ShowError(string message);
    }
}