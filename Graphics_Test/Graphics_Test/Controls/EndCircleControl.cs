using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.Control;

namespace Graphics_Test.Controls
{
    public class EndCircleControl :IFlowControl
    {
        public int X { get; }
        public int Y { get; }

        private int qq;
        public EndCircleControl(MouseEventArgs e, int flowNumber)
        {
            
            X = e.X;
            Y = e.Y;
            qq = flowNumber;
        }

        public string Code()
        {
            return "return 0; \n}";
        }
        public string CodeC()
        {
            return "return 0; \n}";
        }
        public string CodeFn()
        {
            return "end";
        }
        public IEnumerable<Control> Handler()
        {


            var labels = new List<Label>();

            Label l = new Label();
            l.Location = new Point(X - 25, Y + 46);
            l.Size = new Size(60, 20);
            l.Text = "End";
            l.Font = new Font("Arial", 12);
            l.ForeColor = Color.Black;

            labels.Add(l);

            labels.Add(new Label()
            {

                Location = new Point(X - 55, Y + 10),
                Size = new Size(30, 15),
                Text = qq.ToString(),
                Font = new Font("Arial", 12),
                ForeColor = Color.Black,
            });

            return labels;
        }


    }
}
