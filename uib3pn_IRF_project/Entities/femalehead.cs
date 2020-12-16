using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uib3pn_IRF_project.Entities
{
    public class femalehead : Label
    {
        public femalehead()
        {
            AutoSize = false;
            Width = 30;
            Height = Width;
            Paint += Head_Paint;
        }

        private void Head_Paint(object sender, PaintEventArgs e)
        {
            DrawImage(e.Graphics);
        }

        protected void DrawImage(Graphics g)
        {
            g.FillEllipse(new SolidBrush(Color.Pink), 0, 0, Width, Height);
        }
    }
}
