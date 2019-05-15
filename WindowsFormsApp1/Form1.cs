using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public int x1, y1, x2, y2;
        public int lx1, ly1, lx2, ly2;
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            x1 = 0; y1 = 0; x2 = 0; y2 = 0;
        }

        private void LineShape1_Click(object sender, EventArgs e)
        {
            if(x1 !=0 && y1 != 0)
            {
                lx2 = (lineShape1.X1 + lineShape1.X2) / 2;
                ly2 = (lineShape1.Y1 + lineShape1.Y2) / 2;
            }
            lx1 = (lineShape1.X1 + lineShape1.X2) / 2;
            ly1 = (lineShape1.Y1 + lineShape1.Y2) / 2;
        }

        private void LineShape4_Click(object sender, EventArgs e)
        {
            if (x1 != 0 && y1 != 0)
            {
                lx2 = (lineShape4.X1 + lineShape4.X2) / 2;
                ly2 = (lineShape4.Y1 + lineShape4.Y2) / 2;
            }
            lx1 = (lineShape4.X1 + lineShape4.X2) / 2;
            ly1 = (lineShape4.Y1 + lineShape4.Y2) / 2;
        }

        private void LineShape6_Click(object sender, EventArgs e)
        {
            if (x1 != 0 && y1 != 0)
            {
                lx2 = (lineShape6.X1 + lineShape6.X2) / 2;
                ly2 = (lineShape6.Y1 + lineShape6.Y2) / 2;
            }
            lx1 = (lineShape6.X1 + lineShape6.X2) / 2;
            ly1 = (lineShape6.Y1 + lineShape6.Y2) / 2;
        }

        private void LineShape98_Click(object sender, EventArgs e)
        {
            if (x1 != 0 && y1 != 0)
            {
                lx2 = (lineShape98.X1 + lineShape98.X2) / 2;
                ly2 = (lineShape98.Y1 + lineShape98.Y2) / 2;
            }
            lx1 = (lineShape98.X1 + lineShape98.X2) / 2;
            ly1 = (lineShape98.Y1 + lineShape98.Y2) / 2;
        }

        private void LineShape8_Click(object sender, EventArgs e)
        {
            if (x1 != 0 && y1 != 0)
            {
                lx2 = (lineShape8.X1 + lineShape8.X2) / 2;
                ly2 = (lineShape8.Y1 + lineShape8.Y2) / 2;
            }
            lx1 = (lineShape8.X1 + lineShape8.X2) / 2;
            ly1 = (lineShape8.Y1 + lineShape8.Y2) / 2;
        }

        private void LineShape11_Click(object sender, EventArgs e)
        {
            if (x1 != 0 && y1 != 0)
            {
                lx2 = (lineShape11.X1 + lineShape11.X2) / 2;
                ly2 = (lineShape11.Y1 + lineShape11.Y2) / 2;
            }
            lx1 = (lineShape11.X1 + lineShape11.X2) / 2;
            ly1 = (lineShape11.Y1 + lineShape11.Y2) / 2;
        }

        private void LineShape13_Click(object sender, EventArgs e)
        {
            if (x1 != 0 && y1 != 0)
            {
                lx2 = (lineShape13.X1 + lineShape13.X2) / 2;
                ly2 = (lineShape13.Y1 + lineShape13.Y2) / 2;
            }
            lx1 = (lineShape13.X1 + lineShape13.X2) / 2;
            ly1 = (lineShape13.Y1 + lineShape13.Y2) / 2;
        }

        private void LineShape15_Click(object sender, EventArgs e)
        {
            if (x1 != 0 && y1 != 0)
            {
                lx2 = (lineShape15.X1 + lineShape15.X2) / 2;
                ly2 = (lineShape15.Y1 + lineShape15.Y2) / 2;
            }
            lx1 = (lineShape15.X1 + lineShape15.X2) / 2;
            ly1 = (lineShape15.Y1 + lineShape15.Y2) / 2;
        }

        private void LineShape20_Click(object sender, EventArgs e)
        {
            if (x1 != 0 && y1 != 0)
            {
                lx2 = (lineShape20.X1 + lineShape20.X2) / 2;
                ly2 = (lineShape20.Y1 + lineShape20.Y2) / 2;
            }
            lx1 = (lineShape20.X1 + lineShape20.X2) / 2;
            ly1 = (lineShape20.Y1 + lineShape20.Y2) / 2;
        }

        private void LineShape24_Click(object sender, EventArgs e)
        {
            if (x1 != 0 && y1 != 0)
            {
                lx2 = (lineShape24.X1 + lineShape24.X2) / 2;
                ly2 = (lineShape24.Y1 + lineShape24.Y2) / 2;
            }
            lx1 = (lineShape24.X1 + lineShape24.X2) / 2;
            ly1 = (lineShape24.Y1 + lineShape24.Y2) / 2;
        }

        private void LineShape23_Click(object sender, EventArgs e)
        {
            if (x1 != 0 && y1 != 0)
            {
                lx2 = (lineShape23.X1 + lineShape23.X2) / 2;
                ly2 = (lineShape23.Y1 + lineShape23.Y2) / 2;
            }
            lx1 = (lineShape23.X1 + lineShape23.X2) / 2;
            ly1 = (lineShape23.Y1 + lineShape23.Y2) / 2;
        }

        private void LineShape26_Click(object sender, EventArgs e)
        {
            if (x1 != 0 && y1 != 0)
            {
                lx2 = (lineShape26.X1 + lineShape26.X2) / 2;
                ly2 = (lineShape26.Y1 + lineShape26.Y2) / 2;
            }
            lx1 = (lineShape26.X1 + lineShape26.X2) / 2;
            ly1 = (lineShape26.Y1 + lineShape26.Y2) / 2;
        }

        private void LineShape53_Click(object sender, EventArgs e)
        {
            if (x1 != 0 && y1 != 0)
            {
                lx2 = (lineShape53.X1 + lineShape53.X2) / 2;
                ly2 = (lineShape53.Y1 + lineShape53.Y2) / 2;
            }
            lx1 = (lineShape53.X1 + lineShape53.X2) / 2;
            ly1 = (lineShape53.Y1 + lineShape53.Y2) / 2;
        }

        private void LineShape51_Click(object sender, EventArgs e)
        {
            if (x1 != 0 && y1 != 0)
            {
                lx2 = (lineShape51.X1 + lineShape51.X2) / 2;
                ly2 = (lineShape51.Y1 + lineShape51.Y2) / 2;
            }
            lx1 = (lineShape51.X1 + lineShape51.X2) / 2;
            ly1 = (lineShape51.Y1 + lineShape51.Y2) / 2;
        }

        private void LineShape28_Click(object sender, EventArgs e)
        {
            if (x1 != 0 && y1 != 0)
            {
                lx2 = (lineShape28.X1 + lineShape28.X2) / 2;
                ly2 = (lineShape28.Y1 + lineShape28.Y2) / 2;
            }
            lx1 = (lineShape28.X1 + lineShape28.X2) / 2;
            ly1 = (lineShape28.Y1 + lineShape28.Y2) / 2;
        }

        private void LineShape95_Click(object sender, EventArgs e)
        {
            if (x1 != 0 && y1 != 0)
            {
                lx2 = (lineShape95.X1 + lineShape95.X2) / 2;
                ly2 = (lineShape95.Y1 + lineShape95.Y2) / 2;
            }
            lx1 = (lineShape95.X1 + lineShape95.X2) / 2;
            ly1 = (lineShape95.Y1 + lineShape95.Y2) / 2;
        }

        private void LineShape32_Click(object sender, EventArgs e)
        {
            if (x1 != 0 && y1 != 0)
            {
                lx2 = (lineShape32.X1 + lineShape32.X2) / 2;
                ly2 = (lineShape32.Y1 + lineShape32.Y2) / 2;
            }
            lx1 = (lineShape32.X1 + lineShape32.X2) / 2;
            ly1 = (lineShape32.Y1 + lineShape32.Y2) / 2;
        }

        private void LineShape34_Click(object sender, EventArgs e)
        {
            if (x1 != 0 && y1 != 0)
            {
                lx2 = (lineShape34.X1 + lineShape34.X2) / 2;
                ly2 = (lineShape34.Y1 + lineShape34.Y2) / 2;
            }
            lx1 = (lineShape34.X1 + lineShape34.X2) / 2;
            ly1 = (lineShape34.Y1 + lineShape34.Y2) / 2;
        }

        private void LineShape36_Click(object sender, EventArgs e)
        {
            if (x1 != 0 && y1 != 0)
            {
                lx2 = (lineShape36.X1 + lineShape36.X2) / 2;
                ly2 = (lineShape36.Y1 + lineShape36.Y2) / 2;
            }
            lx1 = (lineShape36.X1 + lineShape36.X2) / 2;
            ly1 = (lineShape36.Y1 + lineShape36.Y2) / 2;
        }

        private void LineShape38_Click(object sender, EventArgs e)
        {
            if (x1 != 0 && y1 != 0)
            {
                lx2 = (lineShape38.X1 + lineShape38.X2) / 2;
                ly2 = (lineShape38.Y1 + lineShape38.Y2) / 2;
            }
            lx1 = (lineShape38.X1 + lineShape38.X2) / 2;
            ly1 = (lineShape38.Y1 + lineShape38.Y2) / 2;
        }

        private void LineShape42_Click(object sender, EventArgs e)
        {
            if (x1 != 0 && y1 != 0)
            {
                lx2 = (lineShape42.X1 + lineShape42.X2) / 2;
                ly2 = (lineShape42.Y1 + lineShape42.Y2) / 2;
            }
            lx1 = (lineShape42.X1 + lineShape42.X2) / 2;
            ly1 = (lineShape42.Y1 + lineShape42.Y2) / 2;
        }

        private void LineShape45_Click(object sender, EventArgs e)
        {
            if (x1 != 0 && y1 != 0)
            {
                lx2 = (lineShape45.X1 + lineShape45.X2) / 2;
                ly2 = (lineShape45.Y1 + lineShape45.Y2) / 2;
            }
            lx1 = (lineShape45.X1 + lineShape45.X2) / 2;
            ly1 = (lineShape45.Y1 + lineShape45.Y2) / 2;
        }

        private void LineShape44_Click(object sender, EventArgs e)
        {
            if (x1 != 0 && y1 != 0)
            {
                lx2 = (lineShape44.X1 + lineShape44.X2) / 2;
                ly2 = (lineShape44.Y1 + lineShape44.Y2) / 2;
            }
            lx1 = (lineShape44.X1 + lineShape44.X2) / 2;
            ly1 = (lineShape44.Y1 + lineShape44.Y2) / 2;
        }

        private void LineShape54_Click(object sender, EventArgs e)
        {
            if (x1 != 0 && y1 != 0)
            {
                lx2 = (lineShape54.X1 + lineShape54.X2) / 2;
                ly2 = (lineShape54.Y1 + lineShape54.Y2) / 2;
            }
            lx1 = (lineShape54.X1 + lineShape54.X2) / 2;
            ly1 = (lineShape54.Y1 + lineShape54.Y2) / 2;
        }

        private void LineShape25_Click(object sender, EventArgs e)
        {
            if (x1 != 0 && y1 != 0)
            {
                lx2 = (lineShape25.X1 + lineShape25.X2) / 2;
                ly2 = (lineShape25.Y1 + lineShape25.Y2) / 2;
            }
            lx1 = (lineShape25.X1 + lineShape25.X2) / 2;
            ly1 = (lineShape25.Y1 + lineShape25.Y2) / 2;
        }

        private void LineShape55_Click(object sender, EventArgs e)
        {
            if (x1 != 0 && y1 != 0)
            {
                lx2 = (lineShape55.X1 + lineShape55.X2) / 2;
                ly2 = (lineShape55.Y1 + lineShape55.Y2) / 2;
            }
            lx1 = (lineShape55.X1 + lineShape55.X2) / 2;
            ly1 = (lineShape55.Y1 + lineShape55.Y2) / 2;
        }

        private void LineShape48_Click(object sender, EventArgs e)
        {
            if (x1 != 0 && y1 != 0)
            {
                lx2 = (lineShape48.X1 + lineShape48.X2) / 2;
                ly2 = (lineShape48.Y1 + lineShape48.Y2) / 2;
            }
            lx1 = (lineShape48.X1 + lineShape48.X2) / 2;
            ly1 = (lineShape48.Y1 + lineShape48.Y2) / 2;
        }
        private void LineShape2_Click(object sender, EventArgs e)
        {
            if (x1 != 0 && y1 != 0)
            {
                lx2 = (lineShape1.X1 + lineShape1.X2) / 2;
                ly2 = (lineShape1.Y1 + lineShape1.Y2) / 2;
            }
            lx1 = (lineShape1.X1 + lineShape1.X2) / 2;
            ly1 = (lineShape1.Y1 + lineShape1.Y2) / 2;
        }
        private void LineShape57_Click(object sender, EventArgs e)
        {
            //写错了
        }
        
        private void 复位_Click(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(180, 114);
            
        }
        private void 复位_右_Click(object sender, EventArgs e)
        {
            pictureBox2.Location = new Point(1026, 114);
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            x2 = pictureBox2.Location.X;
            y2 = pictureBox2.Location.Y;
        }

        

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            x1 = pictureBox1.Location.X;
            y1 = pictureBox1.Location.Y;
        }

        

        private void Timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
