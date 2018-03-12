using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;
using System.Speech.Synthesis;

namespace Bate_Papo
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();

            
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Enabled = true;
           
        }
        

        public void falaInicio()
        {
            SpeechSynthesizer s = new SpeechSynthesizer();
            s.Speak("Bem Vindo a central de Jogos!");
            pictureBox1.Image = Bate_Papo.Properties.Resources.assistente2;
            s.Speak("Ao lado você encontra um menu. No qual você escolhe o jogo ou função desejada!");
            pictureBox1.Image = Bate_Papo.Properties.Resources.assistente3;
            s.Speak("Boa sorte!");
            pictureBox1.Image = Bate_Papo.Properties.Resources.assistente1;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            falaInicio();
            timer1.Stop();
            carregarLista();
        }

        public void carregarLista()
        {
            listBox1.Items.Add("Jogo da Velha");
            listBox1.Items.Add("Jogo Sete Erros");
            listBox1.Items.Add("Jogo Da Forca");
            listBox1.Items.Add("Qual a data e hora?");
            listBox1.Items.Add("Quer saber o meu nome?");
            
            listBox1.Items.Add("Calculadora");
            listBox1.Items.Add("Está gostando da semana?");
            listBox1.Items.Add("Quero sair");
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listBox1.SelectedIndex == 0)//Jogo da Velha
            {
                SpeechSynthesizer s = new SpeechSynthesizer();
                pictureBox1.Image = Bate_Papo.Properties.Resources.assistente3;
                s.Speak("Uuumm, Interessante...");
                pictureBox1.Image = Bate_Papo.Properties.Resources.assistente1;
                s.Speak("Jogo da Velha é uma ótima escolha!");
                button1.Visible = true;
                s.Speak("Aperte o botão óqueei para iniciar!");
            }
            if (listBox1.SelectedIndex == 1)//Jogo Sete Erros
            {
                SpeechSynthesizer s = new SpeechSynthesizer();
                pictureBox1.Image = Bate_Papo.Properties.Resources.assistente2;
                s.Speak("Então quer dizer que você acha que nada passa despercebido de você?");
                pictureBox1.Image = Bate_Papo.Properties.Resources.assistente1;
                s.Speak("Veremos nesse jogo");
                button1.Visible = true;
                s.Speak("Apérte o botão óqueei para iniciar!");
            }
            if (listBox1.SelectedIndex == 2)//Jogo da Forca
            {
                SpeechSynthesizer s = new SpeechSynthesizer();
                pictureBox1.Image = Bate_Papo.Properties.Resources.assistente1;
                s.Speak("Está com a corda no pescoço?");
                pictureBox1.Image = Bate_Papo.Properties.Resources.assistente2;
                s.Speak("Por quê não experimentar o jogo da forca");
                button1.Visible = true;
                s.Speak("Apérte o botão óqueei para iniciar!");
            }
            if (listBox1.SelectedIndex == 3)//data e hora
            {
                button1.Visible = false;
                SpeechSynthesizer s = new SpeechSynthesizer();
                string hora = DateTime.Now.ToString();
                pictureBox1.Image = Bate_Papo.Properties.Resources.assistente3;
                s.Speak("Hoje é " + hora);
                pictureBox1.Image = Bate_Papo.Properties.Resources.assistente2;
                s.Speak("Da próxima vez você lembra de trazer um relógio!");
                
            }
            if (listBox1.SelectedIndex == 4)//Nome da Kitty
            {
                button1.Visible = false;
                SpeechSynthesizer s = new SpeechSynthesizer();
                pictureBox1.Image = Bate_Papo.Properties.Resources.assistente3;
                s.Speak("Uuummmm, ta querendo saber demais...");
                pictureBox1.Image = Bate_Papo.Properties.Resources.assistente2;
                s.Speak("O meu nome é kitty!");
                pictureBox1.Image = Bate_Papo.Properties.Resources.assistente2;
                s.Speak("E eu sou uma assistente virtual, mas sem abusos espertinho! Não sou esse tipo de assistente!");
                s.Speak("Nem pense em me chamar pra sair");
            }
            
            if (listBox1.SelectedIndex == 5)//Calculadora
            {
                button1.Visible = false;
                SpeechSynthesizer s = new SpeechSynthesizer();
                pictureBox1.Image = Bate_Papo.Properties.Resources.assistente3;
                s.Speak("Uuummmm, ta querendo saber demais...");
                pictureBox1.Image = Bate_Papo.Properties.Resources.assistente2;
                s.Speak("O meu nome é kitty!");
                pictureBox1.Image = Bate_Papo.Properties.Resources.assistente2;
                s.Speak("E eu sua assistente virtual, mas sem abusos espertinho! não sou esse tipo de assistente!");
                s.Speak("Nem pense em me chamar pra sair");
            }
            if (listBox1.SelectedIndex == 6)//Avaliação Semana
            {
                button1.Visible = false;
                SpeechSynthesizer s = new SpeechSynthesizer();
                pictureBox1.Image = Bate_Papo.Properties.Resources.assistente1;
                s.Speak("Você está gostando da semana?");
                s.Speak("Responda abaixo");
                rbSim.Visible = true;
                rbNao.Visible = true;

            }
            if (listBox1.SelectedIndex == 7)//Sair
            {
                button1.Visible = false;
                SpeechSynthesizer s = new SpeechSynthesizer();
                pictureBox1.Image = Bate_Papo.Properties.Resources.assistente2;
                s.Speak("Que pena que já está de saída!");
                textBox1.Visible = true;
                textBox1.Focus();
                s.Speak("Informe seu nome abaixo para sair");
                s.Speak("Após concluir pressione enter!");


            }
        }

        private void rbSim_CheckedChanged(object sender, EventArgs e)
        {
            if(rbSim.Checked == true)
            {
                rbSim.Checked = false;
                rbSim.Visible = false;
                rbNao.Visible = false;
                SpeechSynthesizer s = new SpeechSynthesizer();
                pictureBox1.Image = Bate_Papo.Properties.Resources.assistente3;
                s.Speak("Como eu imaginei!Todos estão amando");
                s.Speak("Realmente está demais essa semana, deveria ter mais de uma vez ao ano!");
                pictureBox1.Image = Bate_Papo.Properties.Resources.assistente1;
                s.Speak("Aaaaaaaaaaa, aquela festa de ontem nem me fale, ú rúuu, quero mais!!!");
            }
            
        }

        private void rbNao_CheckedChanged(object sender, EventArgs e)
        {
            if(rbNao.Checked == true)
            {
                rbNao.Checked = false;
                rbSim.Visible = false;
                rbNao.Visible = false;
                SpeechSynthesizer s = new SpeechSynthesizer();
                pictureBox1.Image = Bate_Papo.Properties.Resources.assistente2;
                s.Speak("Só você não está gostando");
                s.Speak("Realmente eu achei que você fosse um pouquinho melhor!");
            }
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                pictureBox1.Image = Bate_Papo.Properties.Resources.assistente3;
                SpeechSynthesizer s = new SpeechSynthesizer();
                string nome = textBox1.Text;
                s.Speak("Muito Obrigada " + nome + " Até breve! e Aproveite");
                fechar();
            }
        }

        public void fechar()
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex == 0)//Jogo da Velha
            {
                FormJogoDaVelha velha = new FormJogoDaVelha();
                velha.Show();
            }
            if (listBox1.SelectedIndex == 1)//Jogo Sete Erros
            {
                Form7Erros erros = new Form7Erros();
                erros.Show();
            }
            if (listBox1.SelectedIndex == 2)//Jogo da Forca
            {
                FormForca forca = new FormForca();
                forca.Show();
            }
        }
    }
}
