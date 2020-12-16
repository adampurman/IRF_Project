using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uib3pn_IRF_project.Entities
{
    class femalebody : Label
    {
        public femalebody()
        {
            AutoSize = false;
            Width = 10;
            Height = 100;
            Left = 10;
            Paint += Body_Paint;

        }

        private void Body_Paint(object sender, PaintEventArgs e)
        {
            DrawImage(e.Graphics);
        }

        private void DrawImage(Graphics g)
        {

            g.FillRectangle(new SolidBrush(Color.Pink), 0, 0, Width, Height);
        }


    }
}
