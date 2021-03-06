﻿using System.Drawing.Text;
using System.Windows.Forms;

namespace after_2
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::after_2.Properties.Resources.전툭2;
            this.pictureBox1.Location = new System.Drawing.Point(534, 478);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 73);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // timer2
            // 
            this.timer2.Tick += new System.EventHandler(this.Timer2_tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1224, 652);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        void MakePIcArr(int count)
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox2 = new System.Windows.Forms.PictureBox[count];

            for(int index = 0;index < pictureBox2.Length; index++)
            {
                this.pictureBox2[index] = new System.Windows.Forms.PictureBox();
                ((System.ComponentModel.ISupportInitialize)(this.pictureBox2[index])).BeginInit();

                this.Controls.Add(this.pictureBox2[index]);
                // 
                // pictureBox2
                // 
                this.pictureBox2[index].Image = global::after_2.Properties.Resources.ufo;
                // this.pictureBox2[index].Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
                this.pictureBox2[index].Location = new System.Drawing.Point(300 + 80 * index, 95);
                this.pictureBox2[index].Name = "pictureBox2" + index;
                this.pictureBox2[index].Size = new System.Drawing.Size(34, 36);
                this.pictureBox2[index].SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                this.pictureBox2[index].TabIndex = 2;
                this.pictureBox2[index].TabStop = false;
                ((System.ComponentModel.ISupportInitialize)(this.pictureBox2[index])).EndInit();
            }
        }

        private PictureBox MakeBullet()
        {
            System.Windows.Forms.PictureBox pictureBox3;
            pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(pictureBox3)).BeginInit();

            // 
            // pictureBox3
            // 
            pictureBox3.Image = global::after_2.Properties.Resources.bullet;
            pictureBox3.Location = new System.Drawing.Point(pictureBox1.Location.X + 19, pictureBox1.Location.Y - 30);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new System.Drawing.Size(32, 38);
            pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;

            Controls.Add(pictureBox3);
            ((System.ComponentModel.ISupportInitialize)(pictureBox3)).EndInit();
            return pictureBox3;
        }


        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox[] pictureBox2;
        private System.Windows.Forms.Timer timer1;
        private Timer timer2;
    }
}

