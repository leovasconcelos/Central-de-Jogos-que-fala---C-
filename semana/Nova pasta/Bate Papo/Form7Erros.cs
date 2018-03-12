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
    public partial class Form7Erros : Form
    {
        public Form7Erros()
        {
            InitializeComponent();
        }

        int i;
        private void verificar()
        {
            if (i==7)
            {
                MessageBox.Show("Parabêns voce realmente encontrou os 7 erros, Cê é o bichão mesmo!", "Achou!");
            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.BackColor = Color.Black;
            pictureBox9.BackColor = Color.Black;
            pictureBox2.Enabled = false;
            pictureBox9.Enabled = false;
            pictureBox2.Visible = true;
            pictureBox9.Visible = true;

            i++;
            verificar();
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            pictureBox9.BackColor = Color.Black;
            pictureBox2.BackColor = Color.Black;
            pictureBox2.Enabled = false;
            pictureBox9.Enabled = false;

            i++;
            verificar();
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            pictureBox8.BackColor = Color.Black;
            pictureBox14.BackColor = Color.Black;
            pictureBox8.Enabled = false;
            pictureBox14.Enabled = false;

            i++;
            verificar();

        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            pictureBox8.BackColor = Color.Black;
            pictureBox14.BackColor = Color.Black;
            pictureBox8.Enabled = false;
            pictureBox14.Enabled = false;

            i++;
            verificar();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.Black;
            pictureBox11.BackColor = Color.Black;
            pictureBox3.Enabled = false;
            pictureBox11.Enabled = false;

            i++;
            verificar();
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            pictureBox3.BackColor = Color.Black;
            pictureBox11.BackColor = Color.Black;
            pictureBox3.Enabled = false;
            pictureBox11.Enabled = false;

            i++;
            verificar();
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            pictureBox13.BackColor = Color.Black;
            pictureBox7.BackColor = Color.Black;
            pictureBox13.Enabled = false;
            pictureBox7.Enabled = false;

            i++;
            verificar();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            pictureBox13.BackColor = Color.Black;
            pictureBox7.BackColor = Color.Black;
            pictureBox13.Enabled = false;
            pictureBox7.Enabled = false;

            i++;
            verificar();
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            pictureBox12.BackColor = Color.Black;
            pictureBox5.BackColor = Color.Black;
            pictureBox12.Enabled = false;
            pictureBox5.Enabled = false;
             
            i++;
            verificar();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox12.BackColor = Color.Black;
            pictureBox5.BackColor = Color.Black;
            pictureBox12.Enabled = false;
            pictureBox5.Enabled = false;
            i++;
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            pictureBox10.BackColor = Color.Black;
            pictureBox6.BackColor = Color.Black;
            pictureBox10.Enabled = false;
            pictureBox6.Enabled = false;
            i++;
            verificar();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pictureBox10.BackColor = Color.Black;
            pictureBox6.BackColor = Color.Black;
            pictureBox10.Enabled = false;
            pictureBox6.Enabled = false;
            i++;
            verificar();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            pictureBox15.BackColor = Color.Black;
            pictureBox4.BackColor = Color.Black;
            pictureBox15.Enabled = false;
            pictureBox4.Enabled = false;
            i++;
            verificar();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            pictureBox15.BackColor = Color.Black;
            pictureBox4.BackColor = Color.Black;
            pictureBox15.Enabled = false;
            pictureBox4.Enabled = false;
            i++;
            verificar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form7Erros_Load(object sender, EventArgs e)
        {
            pictureBox2.Image = Bate_Papo.Properties.Resources.sem_nada;
            pictureBox3.Image = Bate_Papo.Properties.Resources.sem_nada;
            pictureBox4.Image = Bate_Papo.Properties.Resources.sem_nada;
            pictureBox5.Image = Bate_Papo.Properties.Resources.sem_nada;
            pictureBox6.Image = Bate_Papo.Properties.Resources.sem_nada;
            pictureBox7.Image = Bate_Papo.Properties.Resources.sem_nada;
            pictureBox8.Image = Bate_Papo.Properties.Resources.sem_nada;
            pictureBox9.Image = Bate_Papo.Properties.Resources.sem_nada;
            pictureBox10.Image = Bate_Papo.Properties.Resources.sem_nada;
            pictureBox11.Image = Bate_Papo.Properties.Resources.sem_nada;
            pictureBox12.Image = Bate_Papo.Properties.Resources.sem_nada;
            pictureBox13.Image = Bate_Papo.Properties.Resources.sem_nada;
            pictureBox14.Image = Bate_Papo.Properties.Resources.sem_nada;
            pictureBox15.Image = Bate_Papo.Properties.Resources.sem_nada;
        }
    }
    }

