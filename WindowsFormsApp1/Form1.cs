﻿using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.VisualBasic.PowerPacks;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public int x1, y1, x2, y2;
        public int lx1, ly1, lx2, ly2;
        public int Velocity1 = 10;
        public int Velocity2 = 10;
        public int pic1click = 0;
        public int pic2click = 0;
        public int flag = 0;
        LineShape[] lines = new LineShape[21];
        OvalShape[] oval1 = new OvalShape[15];
        OvalShape[] oval2 = new OvalShape[15];
        public Form1()
        {
            InitializeComponent();
            lines[0] = lineShape101; lines[1] = lineShape6; lines[2] = lineShape98; lines[3] = lineShape8;
            lines[4] = lineShape11; lines[5] = lineShape13; lines[6] = lineShape15; lines[7] = lineShape23;
            lines[8] = lineShape103; lines[9] = lineShape104; lines[10] = lineShape42; lines[11] = lineShape38;
            lines[12] = lineShape36; lines[13] = lineShape34; lines[14] = lineShape32; lines[15] = lineShape95;
            lines[16] = lineShape28; lines[17] = lineShape100; lines[18] = lineShape99; lines[19] = lineShape106;
            lines[20] = lineShape105;

            oval1[0] = ovalShape2; oval1[1] = ovalShape6; oval1[2] = ovalShape5; oval1[3] = ovalShape29;
            oval1[4] = ovalShape30; oval1[5] = ovalShape8; oval1[6] = ovalShape7; oval1[7] = ovalShape10;
            oval1[8] = ovalShape9; oval1[9] = ovalShape12; oval1[10] = ovalShape11; oval1[11] = ovalShape13;
            oval1[12] = ovalShape14; oval1[13] = ovalShape15; oval1[14] = ovalShape16;

            oval2[0] = ovalShape1; oval2[1] = ovalShape17; oval2[2] = ovalShape18; oval2[3] = ovalShape19;
            oval2[4] = ovalShape20; oval2[5] = ovalShape21; oval2[6] = ovalShape22; oval2[7] = ovalShape23;
            oval2[8] = ovalShape24; oval2[9] = ovalShape25; oval2[10] = ovalShape26; oval2[11] = ovalShape27;
            oval2[12] = ovalShape28; oval2[13] = ovalShape4; oval2[14] = ovalShape3;
        }
        public void ReSet()
        {
            x1 = 0; y1 = 0; x2 = 0; y2 = 0;
            lx1 = 0; lx2 = 0; ly1 = 0; ly2 = 0;
            pic2click = 0;
            pic1click = 0;
            flag = 0;
            for (int i = 1; i < 15; i += 2)
            {
                oval1[i].BackColor = Color.Green;
                oval2[i].BackColor = Color.Green;
                if (i + 1 < 15)
                {
                    oval1[i + 1].BackColor = Color.White;
                    oval2[i + 1].BackColor = Color.White;
                }
            }
            for (int i = 0; i < 20; i++)
            {
                lines[i].BorderColor = Color.Black;
            }
        }
        private void Form1_Load(object sender, EventArgs e) => ReSet();
        private void 停车_Click(object sender, EventArgs e) => timer1.Stop();
        private void 开车2_Click(object sender, EventArgs e) => timer2.Start();
        private void 停车2_Click(object sender, EventArgs e) => timer2.Stop();
        private void 开车_Click(object sender, EventArgs e) => timer1.Start();
        private void PictureBox2_Click(object sender, EventArgs e)
        {
            x2 = pictureBox2.Location.X+20;
            y2 = pictureBox2.Location.Y;
            pic2click = 1;
            pic1click = 0;
        }


        private void PictureBox2_DoubleClick(object sender, EventArgs e)
        {
            pictureBox2.Image.RotateFlip(RotateFlipType.Rotate180FlipY);
            pictureBox2.Refresh();
        }

        private void SetVelocity(ref int v, int num) => v = num;

        private void Button1_Click(object sender, EventArgs e) => SetVelocity(ref Velocity2, 10);

        private void Button2_Click(object sender, EventArgs e)
        {
            SetVelocity(ref Velocity2, 12);
            flag = 1;
            if ((pictureBox2.Location.Y + 22 == ly2)&&(pictureBox2.Location.X<lineShape100.X2))
            {
                for (int i = 1; i < 15; i += 2)
                {
                    oval2[i].BackColor = Color.Red;
                }
            }
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            x1 = pictureBox1.Location.X+20;
            y1 = pictureBox1.Location.Y;
            pic1click = 1;
            pic2click = 0;
        }
        private void LineShape_Click(object sender, EventArgs e)
        {
            LineShape lineShape = (LineShape)sender;
            if (pic2click == 1)
            {
                lx2 = (lineShape.X1 + lineShape.X2) / 2;
                ly2 = (lineShape.Y1 + lineShape.Y2) / 2;
            }
            if (pic1click == 1)
            {
                lx1 = (lineShape.X1 + lineShape.X2) / 2;
                ly1 = (lineShape.Y1 + lineShape.Y2) / 2;
            }
            
        }
        private void LineShape_DoubleClick(object sender, EventArgs e)
        {
            LineShape lineShape = (LineShape)sender;
            if (pic2click == 1)
            {
                lx2 = (lineShape.X1 + lineShape.X2) / 2;
                ly2 = (lineShape.Y1 + lineShape.Y2) / 2;
                pictureBox2.Location = new Point(lx2 - 20, ly2 - 22);
                ReSet();
            }
            if (pic1click == 1)
            {
                lx1 = (lineShape.X1 + lineShape.X2) / 2;
                ly1 = (lineShape.Y1 + lineShape.Y2) / 2;
                pictureBox1.Location = new Point(lx1 - 20, ly1 - 22);
                ReSet();
            }
        }
        public void Straight(int v, int start, int end, PictureBox pictureBox)
        {
            try
            {
                pictureBox.Left += v * (end - start) / Math.Abs(end - start);
            }
            catch (Exception)
            {
                timer1.Stop();
                timer2.Stop();
                MessageBox.Show("请正常办理进路！");
            }

        }
        private void Timer1_Tick(object sender, EventArgs e)
        {
            Straight(Velocity1, x1, lx1, pictureBox1);
            if (Math.Abs(pictureBox1.Location.X + 20 - lx1) < 10)
            {
                x1 = 0; y1 = 0;
                lx1 = 0;ly1 = 0;
                pic1click = 0;
                timer1.Stop();
            }
            for (int i = 0; i < 20; i++)
            {
                if(pictureBox1.Location.Y == lines[i].Y1 - 22)
                {
                    if((pictureBox1.Location.X + 40 >= lines[i].X1) && (pictureBox1.Location.X+40 <= lines[i].X2))
                    {
                        lines[i].BorderColor = Color.Red;
                    }else
                    {
                        lines[i].BorderColor = Color.Black;
                    }
                }
                else
                {
                    lines[i].BorderColor = Color.Black;
                }
            }
            for (int i = 1; i < 15; i+=2)
            {
                if(Math.Abs(pictureBox1.Location.X +40 - oval1[i].Location.X+13)<=5)
                {
                    oval1[i].BackColor = Color.Red;
                    if ((i - 2) > 0 )
                    {
                        oval1[i - 2].BackColor = Color.Yellow;
                    }
                    if ((i - 3) > 0 )
                    {
                        oval1[i - 3].BackColor = Color.Yellow;
                    }
                    if ((i - 4) > 0 )
                    {
                        oval1[i - 4].BackColor = Color.Green;
                    }
                    if ((i - 5) > 0 )
                    {
                        oval1[i - 5].BackColor = Color.White;
                    }
                }    
            }
            if (Math.Abs(pictureBox1.Location.X+40 - 1039)<=5)
            {
                for (int i = 1; i < 15; i += 2)
                {
                    oval1[i].BackColor = Color.Green;
                }
                oval1[10].BackColor = Color.White;
            }
            if (Math.Abs(pictureBox1.Location.X + 40 - 1124) <= 5)
            {
                timer1.Stop();
            }
        }
        private void Timer2_Tick(object sender, EventArgs e)
        {
            if((pictureBox1.Location.Y == pictureBox2.Location.Y)&&(pictureBox1.Location.X - pictureBox2.Location.X<=180))
            {
                Straight(Velocity2, x2, lx2, pictureBox2);
                Velocity2 -= Velocity2 > 0 ? 1 : 0;
            }
            else
            {
                Straight(Velocity2, x2, lx2, pictureBox2);
            }
            Straight(Velocity2, x2, lx2, pictureBox2);
            if (Math.Abs(pictureBox2.Location.X + 20 - lx2) < 10)
            {
                x2 = 0; y2 = 0;
                lx2 = 0;ly2 = 0;
                pic2click = 0;
                flag = 1;
                timer2.Stop();
            }
            for (int i = 0; i < 20; i++)
            {
                if (pictureBox2.Location.Y == lines[i].Y1 - 22)
                {
                    if ((pictureBox2.Location.X <= lines[i].X2) && (pictureBox2.Location.X >= lines[i].X1))
                    {
                        lines[i].BorderColor = Color.Red;
                    }
                    else
                    {
                        lines[i].BorderColor = Color.Black;
                    }
                }
                else
                {
                    lines[i].BorderColor = Color.Black;
                }
            }
            for (int i = 1; i < 15; i += 2)
            {
                if ((Math.Abs(pictureBox2.Location.X - oval2[i].Location.X - 14) <= 5) && flag == 0)
                {
                    oval2[i].BackColor = Color.Red;
                    if ((i - 2) > 0)
                    {
                        oval2[i - 2].BackColor = Color.Yellow;
                    }
                    if ((i - 3) > 0)
                    {
                        oval2[i - 3].BackColor = Color.Yellow;
                    }
                    if ((i - 4) > 0)
                    {
                        oval2[i - 4].BackColor = Color.Green;
                    }
                    if ((i - 5) > 0)
                    {
                        oval2[i - 5].BackColor = Color.White;
                    }
                }

            }
            if (Math.Abs(pictureBox2.Location.X - 235) <= 5)
            {
                for (int i = 1; i < 15; i += 2)
                {
                    oval2[i].BackColor = Color.Green;
                }
                oval2[10].BackColor = Color.White;
            }
            if (Math.Abs(pictureBox2.Location.X - 150) <= 5)
            {
                timer2.Stop();
            }
        }
    }
}
