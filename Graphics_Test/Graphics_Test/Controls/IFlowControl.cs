using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graphics_Test.Controls
{
    public interface IFlowControl
    {
        int Y { get; }
        int X { get; }

        string Code();
        string CodeC();
        string CodeFn();
        IEnumerable<System.Windows.Forms.Control> Handler();
    }
}
