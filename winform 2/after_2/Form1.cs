using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace after_2
{
    public partial class Form1 : Form
    {
        int SizeOfSnow = 10;
        public Form1()
        {
            InitializeComponent();
            MakePIcArr(SizeOfSnow);
            timer1.Start();
            timer2.Start();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            pictureBox1.Left = e.X;
            pictureBox1.Top = e.Y;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                pictureBox1.Left -= 10;
            }
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                pictureBox1.Left -= 10;
            }
            if (e.KeyCode == Keys.Right)
            {
                pictureBox1.Left += 10;
            }
            if (e.KeyCode == Keys.Up)
            {
                pictureBox1.Top -= 10;
            }
            if (e.KeyCode == Keys.Down)
            {
                pictureBox1.Top += 10;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < SizeOfSnow; i++)
            {
                pictureBox2[i].Top += 10;
                if (pictureBox2[i].Top > 750)
                {
                    pictureBox2[i].Top = 0;
                }
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Random rand = new Random();
            for(int i = 0; i < SizeOfSnow; i++)
            {
                pictureBox2[i].Top = rand.Next(0, this.Height - pictureBox2[i].Height*2 - 100);
                pictureBox2[i].Left = rand.Next(0, this.Width - pictureBox2[i].Width);
            }
        }
    }
}