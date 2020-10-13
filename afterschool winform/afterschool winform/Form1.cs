using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace afterschool_winform
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
            webBrowser1.Navigate("google.com");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Contains(".com"))
            {
                webBrowser1.Navigate(textBox1.Text);
            }
            else if (textBox1.Text.Contains(".net"))
            {
                webBrowser1.Navigate(textBox1.Text);
            }
            else
            {
                webBrowser1.Navigate("https://www.google.com/search?q=" + textBox1.Text);
            }
            textBox1.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();
        }
    }
}
