using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphics_Test.Controls
{
    public class StartCirceControl : BaseFlowControl
    {
        public StartCirceControl(MouseEventArgs e, int flowNumber) : base(e, flowNumber)
        {
        }

        public override string Code()
        {
            return "#include<stdio.h> \n\nint main() \n{";
        }

        public override string CodeC()
        {
            return "#include<stdio.h> \n\nint main() \n{";
        }

        public override string CodeFn()
        {
            return "start";
        }

        public override IEnumerable<Control> Handler()
        {
            var labels = new List<Label>();
            labels.Add(new Label() {
                Location = new Point(X + 30, Y + 15),
                Size = new Size(60, 20),
                Text = "Start",
                Font = new Font("Arial", 12),
                ForeColor = Color.Black,
            });

            labels.Add(new Label()
            {
                Location = new Point(X - 15, Y - 10),
                Size = new Size(30, 15),
                Text = qq.ToString(),
                Font = new Font("Arial", 12),
                ForeColor = Color.Black,
            });


            return labels;
        }
    }
}
