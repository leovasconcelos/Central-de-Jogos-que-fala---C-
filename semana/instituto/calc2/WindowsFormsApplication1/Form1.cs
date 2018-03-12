using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           // int a = Convert.ToInt32(txtV1.Text);
           // int b = Convert.ToInt32(txtV2.Text);

          //  lblSoma.Text = Convert.ToString(a + b);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToInt32(txtV1.Text);
            double b = Convert.ToInt32(txtV2.Text);
         

            lblSoma.Text = Convert.ToString(a + b);
            lblMulti.Text = Convert.ToString(a * b);
            lblSub.Text = Convert.ToString(a - b);

            if (a == 0 || b == 0)
            {

                MessageBox.Show("tem zewro nao divide", "error404");
                lblDiv.Text = "...";
            }
            else
            {
                lblDiv.Text = Convert.ToString(a / b);
            }
           


            
        }

        private void txtV1_TextChanged(object sender, EventArgs e)
        {
            if (txtV1.Text == "" || txtV2.Text == "")
            { }
            else
            {
                double a = Convert.ToInt32(txtV1.Text);
                double b = Convert.ToInt32(txtV2.Text);


                lblSoma.Text = Convert.ToString(a + b);
                lblMulti.Text = Convert.ToString(a * b);
                lblSub.Text = Convert.ToString(a - b);

                if (a == 0 || b == 0)
                {

                    MessageBox.Show("tem zewro nao divide", "error404");
                    lblDiv.Text = "...";
                }
                else
                {
                    lblDiv.Text = Convert.ToString(a / b);
                }
            }
        }

        private void txtV2_TextChanged(object sender, EventArgs e)
        {
            if (txtV1.Text == "" || txtV2.Text == "")
            { }
            else
            {
                double a = Convert.ToInt32(txtV1.Text);
                double b = Convert.ToInt32(txtV2.Text);


                lblSoma.Text = Convert.ToString(a + b);
                lblMulti.Text = Convert.ToString(a * b);
                lblSub.Text = Convert.ToString(a - b);

                if (a == 0 || b == 0)
                {

                    MessageBox.Show("tem zewro nao divide", "error404");
                    lblDiv.Text = "...";
                }
                else
                {
                    lblDiv.Text = Convert.ToString(a / b);
                }
            }
        }
    }
}
