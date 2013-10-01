using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Atomizer
{
    public interface Highlightable
    {
        void Highlight();
        void Restore();
        void DeHightlight();
    }
}
