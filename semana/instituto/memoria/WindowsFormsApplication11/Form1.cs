using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int i,v=0;
        int a1=0, a2 = 0, a3 = 0, a4 = 0, a5 = 0, a6 = 0, a7 = 0, a8 = 0;
        int b1 = 0, b2 = 0, b3 = 0, b4 = 0, b5 = 0, b6 = 0, b7 = 0, b8 = 0;
        private void verificar()
        {
            if (a1 == 1 && b1 == 1)
            {
                pct1.Image = null;
                pct1.Enabled = false;
                pct2.Image = null;
                pct2.Enabled = false;
                
            }
            if (a2 == 1 && b2 == 1)
            {
                pct3.Image = null;
                pct3.Enabled = false;
                pct4.Image = null;
                pct4.Enabled = false;
              
            }
            if (a3 == 1 && b3 == 1)
            {
                pct5.Image = null;
                pct5.Enabled = false;
                pct6.Image = null;
                pct6.Enabled = false;
                
            }
            if (a4 == 1 && b4 == 1)
            {
                pct7.Image = null;
                pct7.Enabled = false;
                pct8.Image = null;
                pct8.Enabled = false;
                
            }
            if (a5 == 1 && b5 == 1)
            {
                pct10.Image = null;
                pct10.Enabled = false;
                pct9.Image = null;
                pct9.Enabled = false;
               
            }
            if (a6 == 1 && b6 == 1)
            {
                pct11.Image = null;
                pct11.Enabled = false;
                pct12.Image = null;
                pct12.Enabled = false;
               
            }
            if (a7 == 1 && b7 == 1)
            {
                pct13.Image = null;
                pct13.Enabled = false;
                pct14.Image = null;
                pct14.Enabled = false;
               
            }
            if (a8 == 1 && b8 == 1)
            {
                pct15.Image = null;
                pct15.Enabled = false;
                pct16.Image = null;
                pct16.Enabled = false;
              
            }

            if (i > 2)
            {
                pct1.Image = WindowsFormsApplication11.Properties.Resources.matrix;
                pct2.Image = WindowsFormsApplication11.Properties.Resources.matrix;
                pct3.Image = WindowsFormsApplication11.Properties.Resources.matrix;
                pct4.Image = WindowsFormsApplication11.Properties.Resources.matrix;
                pct5.Image = WindowsFormsApplication11.Properties.Resources.matrix;
                pct6.Image = WindowsFormsApplication11.Properties.Resources.matrix;
                pct7.Image = WindowsFormsApplication11.Properties.Resources.matrix;
                pct8.Image = WindowsFormsApplication11.Properties.Resources.matrix;
                pct9.Image = WindowsFormsApplication11.Properties.Resources.matrix;
                pct10.Image = WindowsFormsApplication11.Properties.Resources.matrix;
                pct11.Image = WindowsFormsApplication11.Properties.Resources.matrix;
                pct12.Image = WindowsFormsApplication11.Properties.Resources.matrix;
                pct13.Image = WindowsFormsApplication11.Properties.Resources.matrix;
                pct14.Image = WindowsFormsApplication11.Properties.Resources.matrix;
                pct15.Image = WindowsFormsApplication11.Properties.Resources.matrix;
                pct16.Image = WindowsFormsApplication11.Properties.Resources.matrix;
                    i = 0;
            }

            if (pct1.Enabled == false && pct2.Enabled == false && pct3.Enabled == false
               && pct4.Enabled == false && pct5.Enabled == false && pct6.Enabled == false
               && pct7.Enabled == false && pct8.Enabled == false && pct9.Enabled == false
               && pct10.Enabled == false && pct11.Enabled == false && pct12.Enabled == false
               && pct13.Enabled == false && pct14.Enabled == false && pct15.Enabled == false
               && pct16.Enabled == false)
            {
                MessageBox.Show("", "ganhou !!!");
            }

            }
        

        private void pct1_Click(object sender, EventArgs e)
        {
            pct1.Image = WindowsFormsApplication11.Properties.Resources.c__;
            a1 = 1;
            i++;
            verificar();
            

        }

        private void pct2_Click(object sender, EventArgs e)
        {
            pct2.Image = WindowsFormsApplication11.Properties.Resources.c__;
            
            b1 = 1;
            i++;
            verificar();
           

        }

        private void pct3_Click(object sender, EventArgs e)
        {
            pct3.Image = WindowsFormsApplication11.Properties.Resources.csharp;
            
            a2 = 1;
            i++;
            
            verificar();
        }   
        private void pct4_Click_1(object sender, EventArgs e)
        {
            pct4.Image = WindowsFormsApplication11.Properties.Resources.csharp;
           
            b2 = 1;
            i++;
            verificar();
            
        }

        private void pct5_Click(object sender, EventArgs e)
        {
            pct5.Image = WindowsFormsApplication11.Properties.Resources.bootstrap;
            
            a3 = 1;
            i++;
            verificar();
            
        }

        private void pct6_Click(object sender, EventArgs e)
        {
            pct6.Image = WindowsFormsApplication11.Properties.Resources.bootstrap;
           
            b3 = 1;
            i++;
            verificar();
            
        }

        private void pct7_Click(object sender, EventArgs e)
        {
            pct7.Image = WindowsFormsApplication11.Properties.Resources.CSSlogo;
            
            a4 = 1;
            i++;
            verificar();
           
        }

        private void pct8_Click(object sender, EventArgs e)
        {
            pct8.Image = WindowsFormsApplication11.Properties.Resources.CSSlogo;
            
            b4 = 1;
            i++;
            verificar();
            
        }

        private void pct9_Click(object sender, EventArgs e)
        {
            pct9.Image = WindowsFormsApplication11.Properties.Resources.JavaLogo;
            a5 = 1;
            
            i++;
            verificar();
            
        }

        private void pct10_Click(object sender, EventArgs e)
        {
            pct10.Image = WindowsFormsApplication11.Properties.Resources.JavaLogo;
            b5 = 1;
            
            i++;
            verificar();
           
        }

        private void pct11_Click(object sender, EventArgs e)
        {
            pct11.Image = WindowsFormsApplication11.Properties.Resources.MySQL_logo;
            a6 = 1;
            
            i++;
            verificar();
            
        }

        private void pct12_Click(object sender, EventArgs e)
        {
            pct12.Image = WindowsFormsApplication11.Properties.Resources.MySQL_logo;
            b6 = 1;
           
            i++;
            verificar();
           
        }

        private void pct13_Click(object sender, EventArgs e)
        {
            pct13.Image = WindowsFormsApplication11.Properties.Resources.python_logo;
            a7 = 1;
            
            i++;
            verificar();
          
        }

        private void pct14_Click(object sender, EventArgs e)
        {
            pct14.Image = WindowsFormsApplication11.Properties.Resources.python_logo;
            b7 = 1;
           
            i++;
            verificar();
       
        }

        private void pct15_Click(object sender, EventArgs e)
        {
            pct15.Image = WindowsFormsApplication11.Properties.Resources.c;
            a8 = 1;
            i++;
            verificar();
    
            
            
        }

        private void pct16_Click(object sender, EventArgs e)
        {
            pct16.Image = WindowsFormsApplication11.Properties.Resources.c;
            b8 = 1;
            
            i++;

            verificar();
        }
    }
}
