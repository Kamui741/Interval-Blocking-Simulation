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
        public void ReSet()
        {
            x1 = 0;
            y1 = 0;
            x2 = 0;
            y2 = 0;
            lx1 = 0;
            lx2 = 0;
            ly1 = 0;
            ly2 = 0;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            x1 = 0; y1 = 0; x2 = 0; y2 = 0;
        }

        private void 开车_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void 复位_Click(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(180, 114);
            pictureBox2.Location = new Point(1026, 114);
            ReSet();
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

        private void LineShape_Click(object sender, EventArgs e)
        {
            Microsoft.VisualBasic.PowerPacks.LineShape lineShape = (Microsoft.VisualBasic.PowerPacks.LineShape)sender;
            if (x2 != 0 && y2 != 0)
            {
                lx2 = (lineShape.X1 + lineShape.X2) / 2;
                ly2 = (lineShape.Y1 + lineShape.Y2) / 2;
            }
            lx1 = (lineShape.X1 + lineShape.X2) / 2;
            ly1 = (lineShape.Y1 + lineShape.Y2) / 2;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            pictureBox1.Left += (lx1 - x1)/50;
            pictureBox2.Left += (lx2 - x2)/50 ;
            if (Math.Abs(ly1 - y1) == 22 || Math.Abs(ly2-y2)==22)
            {
                if (lx1 != 0 && lx2 == 0)
                {
                    if (Math.Abs(lx1 - pictureBox1.Location.X)<=1 )
                    {
                        ReSet();
                        timer1.Stop();
                    }

                }
                if (lx2 != 0 && lx1 == 0)
                {
                    if (Math.Abs(lx2 - pictureBox2.Location.X) <= 1)
                    {
                        ReSet();
                        timer1.Stop();
                    }

                }
                if (lx1 != 0 && lx2 != 0)
                {
                    if ((Math.Abs(lx1 - pictureBox1.Location.X) <= 1)&&(Math.Abs(lx2 - pictureBox2.Location.X) <= 1))
                    {
                        ReSet();
                        timer1.Stop();
                    }

                }
            }
            pictureBox1.Refresh();
        }
    }
}
