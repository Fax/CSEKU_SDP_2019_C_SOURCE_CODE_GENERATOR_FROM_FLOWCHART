using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphics_Test.Controls
{
    public abstract class BaseFlowControl : IFlowControl
    {
        public BaseFlowControl(MouseEventArgs e, int flowNumber)
        {
            X = e.X;
            Y = e.Y;
            qq = flowNumber;
        }
        public int Y { get; }

        protected int qq;

        public int X { get; }

        public abstract string Code();
        public abstract string CodeC();
        public abstract string CodeFn();
        public abstract IEnumerable<Control> Handler();
    }
}
