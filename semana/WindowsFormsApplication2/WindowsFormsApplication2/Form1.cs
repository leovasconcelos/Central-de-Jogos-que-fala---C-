using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";
            label4.Text = "";

            label1.Text = "test";
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            if (label1.Text != "")
            {
                label2.Text = "test";
                label1.Text = "";
                timer1.Enabled = false;
                timer2.Start();
            }
            else if (label2.Text != "")
            {
                label3.Text = "test";
                label2.Text = "";
                timer2.Enabled = false;
                timer3.Start();

            }
            else if (label3.Text != "")
            {
                label4.Text = "test";
                label3.Text = "";
            }
            timer1.Enabled = false;

        }


        private void timer2_Tick(object sender, EventArgs e)
        {
            if (label1.Text != "")
            {
                label2.Text = "test";
                label1.Text = "";
                timer1.Enabled = false;
                timer2.Start();
            }
            else if (label2.Text != "")
            {
                label3.Text = "test";
                label2.Text = "";
                timer2.Enabled = false;
                timer3.Start();

            }
            else if (label3.Text != "")
            {
                label4.Text = "test";
                label3.Text = "";
            }
            timer2.Enabled = false;

        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            if (label1.Text != "")
            {
                label2.Text = "test";
                label1.Text = "";
                timer1.Enabled = false;
                timer2.Start();
            }
            else if (label2.Text != "")
            {
                label3.Text = "test";
                label2.Text = "";
                timer2.Enabled = false;
                timer3.Start();

            }
            else if (label3.Text != "")
            {
                label4.Text = "test";
                label3.Text = "";
            }
            timer3.Enabled = false;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = WindowsFormsApplication2.Properties.Resources.xis;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = @"";
        }

    }
}
