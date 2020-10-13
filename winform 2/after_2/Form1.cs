using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace after_2
{
    public partial class Form1 : Form
    {
        List<PictureBox> bulletList;
        List<PictureBox> removeList;
        Thread BulletMoveTh;
        int SizeOfSnow = 10;
        public Form1()
        {
            InitializeComponent();
            MakePIcArr(SizeOfSnow);
            timer1.Start();
            // enemyMove(pictureBox2);
            MakeBullet();
            bulletList = new List<PictureBox>();
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
            if (e.KeyCode == Keys.Space)
            {
                bulletList.Add(MakeBullet());
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

        private void Timer2_tick(object sender, EventArgs e)
        {
            while (bulletList != null)
            {
                foreach (var bullet in this.bulletList)
                {
                    bullet.Top -= 15;
                    if (bullet.Top < -bullet.Top)
                    {
                        removeList.Add(bullet);
                    }
                }
                foreach (var removePicture in removeList)
                {
                    bulletList.Remove(removePicture);
                    this.Controls.Remove(removePicture);
                }
            }
        }

        /*
        private void enemyMove(object i)
        {
            int index = (int)i;
            Random rand = new Random();

            while(true)
            {
                if (pictureBox2[index].Top >= this.Height)
                    pictureBox2[index].Top = -pictureBox2[index].Height;

                pictureBox2[index].Top += 30;
                Thread.Sleep(rand.Next(100));
            }
        }
        */
    }
}