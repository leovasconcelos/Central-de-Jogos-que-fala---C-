using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Speech.Recognition;

namespace JogoDaVeia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            SpeechSynthesizer s = new SpeechSynthesizer();
            s.Speak("Ótima escolha, desafie alguem e chame ele para jogar um jogo da véélha! ra ra ra ra eu duvido você ganhar!");

            InitializeComponent();
            
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "É a vez do jogador: ";
            label2.Text = "X";
            label3.Text = "Pontuação do jogador com X é:";
            label4.Text = "0";
            label5.Text = "Pontuação do jogador com O é:";
            label6.Text = "0";
            p10.ImageLocation = @"C:\Users\Antonio\Downloads\xis.png";
           
        }

        public void zerar()
        {
            p1.ImageLocation = null;
            p1.BackColor = Color.Blue;
            p1.Enabled = true;
            p2.ImageLocation = null;
            p2.BackColor = Color.Blue;
            p2.Enabled = true;
            p3.ImageLocation = null;
            p3.BackColor = Color.Blue;
            p3.Enabled = true;
            p4.ImageLocation = null;
            p4.BackColor = Color.Blue;
            p4.Enabled = true;
            p5.ImageLocation = null;
            p5.BackColor = Color.Blue;
            p5.Enabled = true;
            p6.ImageLocation = null;
            p6.BackColor = Color.Blue;
            p6.Enabled = true;
            p7.ImageLocation = null;
            p7.BackColor = Color.Blue;
            p7.Enabled = true;
            p8.ImageLocation = null;
            p8.BackColor = Color.Blue;
            p8.Enabled = true;
            p9.ImageLocation = null;
            p9.BackColor = Color.Blue;
            p9.Enabled = true;
        }

        public void verificar()
        {
            int x = 0, o = 0;
            //Verificar X 3 Linhas
            if ((p1.ImageLocation == @"C:\Users\Antonio\Downloads\xis.png") && (p2. ImageLocation == @"C:\Users\Antonio\Downloads\xis.png") && (p1.ImageLocation == @"C:\Users\Antonio\Downloads\xis.png") && (p3.ImageLocation == @"C:\Users\Antonio\Downloads\xis.png"))
            {
                MessageBox.Show("O jogador X é o vencedor!!!");
                x = 1;
                label4.Text = Convert.ToString(Convert.ToInt16(label4.Text)+ 1);
                zerar();
            }
           if ((p4.ImageLocation == @"C:\Users\Antonio\Downloads\xis.png") && (p5.ImageLocation == @"C:\Users\Antonio\Downloads\xis.png") && (p4.ImageLocation == @"C:\Users\Antonio\Downloads\xis.png") && (p6.ImageLocation == @"C:\Users\Antonio\Downloads\xis.png"))
            {
                if (x != 1)
                {
                    MessageBox.Show("O jogador X é o vencedor!!!");
                    x = 1;
                    label4.Text = Convert.ToString(Convert.ToInt16(label4.Text) + 1);
                    zerar();
                }
            }
            if ((p7.ImageLocation == @"C:\Users\Antonio\Downloads\xis.png") && (p8.ImageLocation == @"C:\Users\Antonio\Downloads\xis.png") && (p7.ImageLocation == @"C:\Users\Antonio\Downloads\xis.png") && (p9.ImageLocation == @"C:\Users\Antonio\Downloads\xis.png"))
            {
                MessageBox.Show("O jogador X é o vencedor!!!");
                x = 1;
                label4.Text = Convert.ToString(Convert.ToInt16(label4.Text) + 1);
                zerar();
            }
            //Verificar X 3 Colunas
            if ((p1.ImageLocation == @"C:\Users\Antonio\Downloads\xis.png") && (p4.ImageLocation == @"C:\Users\Antonio\Downloads\xis.png") && (p1.ImageLocation == @"C:\Users\Antonio\Downloads\xis.png") && (p7.ImageLocation == @"C:\Users\Antonio\Downloads\xis.png"))
            {
                MessageBox.Show("O jogador X é o vencedor!!!");
                x = 1;
                label4.Text = Convert.ToString(Convert.ToInt16(label4.Text) + 1);
                zerar();
            }
            if ((p2.ImageLocation == @"C:\Users\Antonio\Downloads\xis.png") && (p5.ImageLocation == @"C:\Users\Antonio\Downloads\xis.png") && (p2.ImageLocation == @"C:\Users\Antonio\Downloads\xis.png") && (p8.ImageLocation == @"C:\Users\Antonio\Downloads\xis.png"))
            {
                if (x != 1)
                {
                    MessageBox.Show("O jogador X é o vencedor!!!");
                    x = 1;
                    label4.Text = Convert.ToString(Convert.ToInt16(label4.Text) + 1);
                    zerar();
                }
            }
            if ((p3.ImageLocation == @"C:\Users\Antonio\Downloads\xis.png") && (p6.ImageLocation == @"C:\Users\Antonio\Downloads\xis.png") && (p3.ImageLocation == @"C:\Users\Antonio\Downloads\xis.png") && (p9.ImageLocation == @"C:\Users\Antonio\Downloads\xis.png"))
            {
                MessageBox.Show("O jogador X é o vencedor!!!");
                x = 1;
                label4.Text = Convert.ToString(Convert.ToInt16(label4.Text) + 1);
                zerar();
            }
            //Verificar X 2 Diagonais
            if ((p1.ImageLocation == @"C:\Users\Antonio\Downloads\xis.png") && (p5.ImageLocation == @"C:\Users\Antonio\Downloads\xis.png") && (p1.ImageLocation == @"C:\Users\Antonio\Downloads\xis.png") && (p9.ImageLocation == @"C:\Users\Antonio\Downloads\xis.png"))
            {
                if(x != 1)
                {
                    MessageBox.Show("O jogador X é o vencedor!!!");
                    x = 1;
                    label4.Text = Convert.ToString(Convert.ToInt16(label4.Text) + 1);
                    zerar();
                }
                
            }
            if ((p3.ImageLocation == @"C:\Users\Antonio\Downloads\xis.png") && (p5.ImageLocation == @"C:\Users\Antonio\Downloads\xis.png") && (p3.ImageLocation == @"C:\Users\Antonio\Downloads\xis.png") && (p7.ImageLocation == @"C:\Users\Antonio\Downloads\xis.png"))
            {
                if (x != 1)
                {
                    MessageBox.Show("O jogador X é o vencedor!!!");
                    x = 1;
                    label4.Text = Convert.ToString(Convert.ToInt16(label4.Text) + 1);
                    zerar();
                }
            }


            //Verificar O 3 Linhas
            if ((p1.ImageLocation == @"C:\Users\Antonio\Downloads\circle.png") && (p2.ImageLocation == @"C:\Users\Antonio\Downloads\circle.png") && (p1.ImageLocation == @"C:\Users\Antonio\Downloads\circle.png") && (p3.ImageLocation == @"C:\Users\Antonio\Downloads\circle.png"))
            {
                MessageBox.Show("O jogador O é o vencedor!!!");
                o = 1;
                label6.Text = Convert.ToString(Convert.ToInt16(label6.Text) + 1);
                zerar();
            }
            if ((p4.ImageLocation == @"C:\Users\Antonio\Downloads\circle.png") && (p5.ImageLocation == @"C:\Users\Antonio\Downloads\circle.png") && (p4.ImageLocation == @"C:\Users\Antonio\Downloads\circle.png") && (p6.ImageLocation == @"C:\Users\Antonio\Downloads\circle.png"))
            {
                if (o != 1)
                {
                    MessageBox.Show("O jogador O é o vencedor!!!");
                    o = 1;
                    label6.Text = Convert.ToString(Convert.ToInt16(label6.Text) + 1);
                    zerar();
                }
            }
            if ((p7.ImageLocation == @"C:\Users\Antonio\Downloads\circle.png") && (p8.ImageLocation == @"C:\Users\Antonio\Downloads\circle.png") && (p7.ImageLocation == @"C:\Users\Antonio\Downloads\circle.png") && (p9.ImageLocation == @"C:\Users\Antonio\Downloads\circle.png"))
            {
                MessageBox.Show("O jogador O é o vencedor!!!");
                o = 1;
                label6.Text = Convert.ToString(Convert.ToInt16(label6.Text) + 1);
                zerar();
            }
            //Verificar O 3 Colunas
            if ((p1.ImageLocation == @"C:\Users\Antonio\Downloads\circle.png") && (p4.ImageLocation == @"C:\Users\Antonio\Downloads\circle.png") && (p1.ImageLocation == @"C:\Users\Antonio\Downloads\circle.png") && (p7.ImageLocation == @"C:\Users\Antonio\Downloads\circle.png"))
            {
                MessageBox.Show("O jogador O é o vencedor!!!");
                o = 1;
                label6.Text = Convert.ToString(Convert.ToInt16(label6.Text) + 1);
                zerar();
            }
            if ((p2.ImageLocation == @"C:\Users\Antonio\Downloads\circle.png") && (p5.ImageLocation == @"C:\Users\Antonio\Downloads\circle.png") && (p2.ImageLocation == @"C:\Users\Antonio\Downloads\circle.png") && (p8.ImageLocation == @"C:\Users\Antonio\Downloads\circle.png"))
            {
                if (o != 1)
                {
                    MessageBox.Show("O jogador O é o vencedor!!!");
                    o = 1;
                    label6.Text = Convert.ToString(Convert.ToInt16(label6.Text) + 1);
                    zerar();
                }
            }
            if ((p3.ImageLocation == @"C:\Users\Antonio\Downloads\circle.png") && (p6.ImageLocation == @"C:\Users\Antonio\Downloads\circle.png") && (p3.ImageLocation == @"C:\Users\Antonio\Downloads\circle.png") && (p9.ImageLocation == @"C:\Users\Antonio\Downloads\circle.png"))
            {
                MessageBox.Show("O jogador O é o vencedor!!!");
                o = 1;
                label6.Text = Convert.ToString(Convert.ToInt16(label6.Text) + 1);
                zerar();
            }
            //Verificar O 2 Diagonais
            if ((p1.ImageLocation == @"C:\Users\Antonio\Downloads\circle.png") && (p5.ImageLocation == @"C:\Users\Antonio\Downloads\circle.png") && (p1.ImageLocation == @"C:\Users\Antonio\Downloads\circle.png") && (p9.ImageLocation == @"C:\Users\Antonio\Downloads\circle.png"))
            {
                if (o != 1)
                {
                    MessageBox.Show("O jogador O é o vencedor!!!");
                    o = 1;
                    label6.Text = Convert.ToString(Convert.ToInt16(label6.Text) + 1);
                    zerar();
                }
            }

            if ((p3.ImageLocation == @"C:\Users\Antonio\Downloads\circle.png") && (p5.ImageLocation == @"C:\Users\Antonio\Downloads\circle.png") && (p3.ImageLocation == @"C:\Users\Antonio\Downloads\circle.png") && (p7.ImageLocation == @"C:\Users\Antonio\Downloads\circle.png"))
            {
                if (o != 1)
                {
                    MessageBox.Show("O jogador O é o vencedor!!!");
                    o = 1;
                    label6.Text = Convert.ToString(Convert.ToInt16(label6.Text) + 1);
                    zerar();
                }
            }


            if (p1.ImageLocation != null && p2.ImageLocation != null && p3.ImageLocation != null && p4.ImageLocation != null && p5.ImageLocation != null && p6.ImageLocation != null && p7.ImageLocation != null && p8.ImageLocation != null && p9.ImageLocation != null)
            {
                if((x ==1 && o != 1 )||( x!=1 && o ==0) )
                {
                    MessageBox.Show("Deu Velha!!!");
                    zerar();
                }
                else
                {
                    MessageBox.Show("Deu Velha!!!");
                    zerar();
                }
                
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(label2.Text == "X")
            {
                p1.ImageLocation = @"C:\Users\Antonio\Downloads\xis.png";
                p1.Enabled = false;
                p1.BackColor = Color.Green;
                label2.Text = "O";
                p10.ImageLocation = @"C:\Users\Antonio\Downloads\circle.png";
                verificar();
            }
            else if(label2.Text == "O")
            {
                p1.ImageLocation = @"C:\Users\Antonio\Downloads\circle.png";
                p1.Enabled = false;
                p1.BackColor = Color.White;
                label2.Text = "X";
                p10.ImageLocation = @"C:\Users\Antonio\Downloads\xis.png";
                verificar();
            }
        }

        

        private void p2_Click(object sender, EventArgs e)
        {
            if (label2.Text == "X")
            {
                p2.ImageLocation = @"C:\Users\Antonio\Downloads\xis.png";
                p2.Enabled = false;
                p2.BackColor = Color.Green;
                label2.Text = "O";
                p10.ImageLocation = @"C:\Users\Antonio\Downloads\circle.png";
                verificar();
            }
            else if (label2.Text == "O")
            {
                p2.ImageLocation = @"C:\Users\Antonio\Downloads\circle.png";
                p2.Enabled = false;
                p2.BackColor = Color.White;
                label2.Text = "X";
                p10.ImageLocation = @"C:\Users\Antonio\Downloads\xis.png";
                verificar();
            }
        }

        private void p3_Click(object sender, EventArgs e)
        {
            if (label2.Text == "X")
            {
                p3.ImageLocation = @"C:\Users\Antonio\Downloads\xis.png";
                p3.Enabled = false;
                p3.BackColor = Color.Green;
                label2.Text = "O";
                p10.ImageLocation = @"C:\Users\Antonio\Downloads\circle.png";
                verificar();
            }
            else if (label2.Text == "O")
            {
                p3.ImageLocation = @"C:\Users\Antonio\Downloads\circle.png";
                p3.Enabled = false;
                p3.BackColor = Color.White;
                label2.Text = "X";
                p10.ImageLocation = @"C:\Users\Antonio\Downloads\xis.png";
                verificar();
            }
        }

        private void p4_Click(object sender, EventArgs e)
        {
            if (label2.Text == "X")
            {
                p4.ImageLocation = @"C:\Users\Antonio\Downloads\xis.png";
                p4.Enabled = false;
                p4.BackColor = Color.Green;
                label2.Text = "O";
                p10.ImageLocation = @"C:\Users\Antonio\Downloads\circle.png";
                verificar();
            }
            else if (label2.Text == "O")
            {
                p4.ImageLocation = @"C:\Users\Antonio\Downloads\circle.png";
                p4.Enabled = false;
                p4.BackColor = Color.White;
                label2.Text = "X";
                p10.ImageLocation = @"C:\Users\Antonio\Downloads\xis.png";
                verificar();
            }
        }

        private void p5_Click(object sender, EventArgs e)
        {
            if (label2.Text == "X")
            {
                p5.ImageLocation = @"C:\Users\Antonio\Downloads\xis.png";
                p5.Enabled = false;
                p5.BackColor = Color.Green;
                label2.Text = "O";
                p10.ImageLocation = @"C:\Users\Antonio\Downloads\circle.png";
                verificar();
            }
            else if (label2.Text == "O")
            {
                p5.ImageLocation = @"C:\Users\Antonio\Downloads\circle.png";
                p5.Enabled = false;
                p5.BackColor = Color.White;
                label2.Text = "X";
                p10.ImageLocation = @"C:\Users\Antonio\Downloads\xis.png";
                verificar();
            }
        }

        private void p6_Click(object sender, EventArgs e)
        {
            if (label2.Text == "X")
            {
                p6.ImageLocation = @"C:\Users\Antonio\Downloads\xis.png";
                p6.Enabled = false;
                p6.BackColor = Color.Green;
                label2.Text = "O";
                p10.ImageLocation = @"C:\Users\Antonio\Downloads\circle.png";
                verificar();
            }
            else if (label2.Text == "O")
            {
                p6.ImageLocation = @"C:\Users\Antonio\Downloads\circle.png";
                p6.Enabled = false;
                p6.BackColor = Color.White;
                label2.Text = "X";
                p10.ImageLocation = @"C:\Users\Antonio\Downloads\xis.png";
                verificar();
            }
        }

        private void p7_Click(object sender, EventArgs e)
        {
            if (label2.Text == "X")
            {
                p7.ImageLocation = @"C:\Users\Antonio\Downloads\xis.png";
                p7.Enabled = false;
                p7.BackColor = Color.Green;
                label2.Text = "O";
                p10.ImageLocation = @"C:\Users\Antonio\Downloads\circle.png";
                verificar();
            }
            else if (label2.Text == "O")
            {
                p7.ImageLocation = @"C:\Users\Antonio\Downloads\circle.png";
                p7.Enabled = false;
                p7.BackColor = Color.White;
                label2.Text = "X";
                p10.ImageLocation = @"C:\Users\Antonio\Downloads\xis.png";
                verificar();
            }
        }

        private void p8_Click(object sender, EventArgs e)
        {
            if (label2.Text == "X")
            {
                p8.ImageLocation = @"C:\Users\Antonio\Downloads\xis.png";
                p8.Enabled = false;
                p8.BackColor = Color.Green;
                label2.Text = "O";
                p10.ImageLocation = @"C:\Users\Antonio\Downloads\circle.png";
                verificar();
            }
            else if (label2.Text == "O")
            {
                p8.ImageLocation = @"C:\Users\Antonio\Downloads\circle.png";
                p8.Enabled = false;
                p8.BackColor = Color.White;
                label2.Text = "X";
                p10.ImageLocation = @"C:\Users\Antonio\Downloads\xis.png";
                verificar();
            }
        }

        private void p9_Click(object sender, EventArgs e)
        {
            if (label2.Text == "X")
            {
                p9.ImageLocation = @"C:\Users\Antonio\Downloads\xis.png";
                p9.Enabled = false;
                p9.BackColor = Color.Green;
                label2.Text = "O";
                p10.ImageLocation = @"C:\Users\Antonio\Downloads\circle.png";
                verificar();
            }
            else if (label2.Text == "O")
            {
                p9.ImageLocation = @"C:\Users\Antonio\Downloads\circle.png";
                p9.Enabled = false;
                p9.BackColor = Color.White;
                label2.Text = "X";
                p10.ImageLocation = @"C:\Users\Antonio\Downloads\xis.png";
                verificar();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "É a vez do jogador: ";
            label2.Text = "X";
            label3.Text = "Pontuação do jogador com X é:";
            label4.Text = "0";
            label5.Text = "Pontuação do jogador com O é:";
            label6.Text = "0";
            zerar();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            zerar();
        }
    }
}
