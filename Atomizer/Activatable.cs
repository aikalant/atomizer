using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Atomizer
{
    public interface Activatable : Highlightable
    {
        void TryMakeActive();
        void TryMakeUnactive();

        void ActivationActions();
        void DeactivationActions();
    }
}
