using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bate_Papo
{
    public partial class FormForca : Form
    {
        int i;
        public FormForca()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label6.Text = "A";
            label11.Text = "A";
            button1.Enabled = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label1.Text = "J";
            button10.Enabled = false;
        }

        private void button13_Click(object sender, EventArgs e)
        {
           
            label2.Text = "O";
            label4.Text = "O";
            label8.Text = "O";
            button13.Enabled = false;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label3.Text = "G";
            button7.Enabled = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label5.Text = "D";
            button4.Enabled = false;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label7.Text = "F";
            button6.Enabled = false;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            label9.Text = "R";
            button18.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label10.Text = "C";
            button3.Enabled = false;
        }

       
        private void verificar()
        {
            if(i==1 )
            {
                pictureBox1.Image = Bate_Papo.Properties.Resources.cabeça;
            }
            if (i == 2)
            {
                pictureBox1.Image = Bate_Papo.Properties.Resources.corpo;
            }
            if (i == 3)
            {
                pictureBox1.Image = Bate_Papo.Properties.Resources.b1;
            }
            if (i == 4)
            {
                pictureBox1.Image = Bate_Papo.Properties.Resources.b2;
            }
            if (i == 5)
            {
                pictureBox1.Image = Bate_Papo.Properties.Resources.p1;
            }
            if (i == 6)
            {
                pictureBox1.Image = Bate_Papo.Properties.Resources.morreu;
                MessageBox.Show("perdeu","morreu");
            }

        }
        private void button2_Click(object sender, EventArgs e)
        {
            i++;
            verificar();
            button2.Enabled = false;
            
        }
        private void button5_Click(object sender, EventArgs e)
        {
            i++;
            verificar();
            button5.Enabled = false;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            i++;
            verificar();
            button8.Enabled = false;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            i++;
            verificar();
            button9.Enabled = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            i++;
            button11.Enabled = false;
            verificar();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            i++;
            verificar();
            button12.Enabled = false;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            i++;
            verificar();
            button14.Enabled = false;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            i++;
            verificar();
            button15.Enabled = false;
        }

        private void button16_Click(object sender, EventArgs e)
        {


            i++;
            verificar();
            button16.Enabled = false;
        }

        private void button17_Click(object sender, EventArgs e)
        {

            i++;
            button17.Enabled = false;
            verificar();
        }

        private void button19_Click(object sender, EventArgs e)
        {

            i++;
            verificar();
            button19.Enabled = false;
        }

        private void button20_Click(object sender, EventArgs e)
        {

            i++;
            verificar();
            button20.Enabled = false;
        }

        private void button21_Click(object sender, EventArgs e)
        {

            button21.Enabled = false;
            i++;
            verificar();
        }

        private void button22_Click(object sender, EventArgs e)
        {

            i++;
            button22.Enabled = false;
            verificar();
        }

        private void button24_Click(object sender, EventArgs e)
        {

            i++;
            verificar();
            button24.Enabled = false;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            button26.Enabled = false;
            i++;
            verificar();
        }
    }
}

