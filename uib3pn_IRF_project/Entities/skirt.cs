using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace uib3pn_IRF_project.Entities
{
    public class skirt:Label
    {

        public skirt()
        {

            AutoSize = false; Width = 30;
            Height = Width;
            Paint += Skirt_Paint;
        }

        private void Skirt_Paint(object sender, PaintEventArgs e)
        {
            DrawImage(e.Graphics);
        }

        private void DrawImage(Graphics g)
        {
            Point point1 = new Point(50,50);
            Point point2 = new Point(50,100);
            Point point3 = new Point(100,50);

            Point[] curvepoints = { point1, point2, point3 };
            g.FillPolygon(new SolidBrush(Color.Black),curvepoints);
        }

       
}
}
