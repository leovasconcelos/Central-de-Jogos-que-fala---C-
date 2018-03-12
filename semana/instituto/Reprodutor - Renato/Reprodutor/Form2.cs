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
using System.IO;

namespace Reprodutor
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


  
        private void Form2_Load(object sender, EventArgs e)
        {
            SpeechSynthesizer sSynth = new SpeechSynthesizer();
            PromptBuilder pBuilder = new PromptBuilder();
            SpeechRecognitionEngine sRecognize = new SpeechRecognitionEngine();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Enabled = false;
            button3.Enabled = true;
            Choices sList = new Choices();
            sList.Add(new string[] { "guilherme", "b", "it works", "a", "are", "you", "hoje", "i", "am", "fine", "exit", "close", "quit", "so" });
            Grammar gr = new Grammar(new GrammarBuilder(sList));
            try
            {
                sRecognize.RequestRecognizerUpdate();
                sRecognize.LoadGrammar(gr);
                sRecognize.SpeechRecognized += sRecognize_SpeechRecognized;
                sRecognize.SetInputToDefaultAudioDevice();
                sRecognize.Recognize();


            }

            catch
            {
                return;
            }
        }
        private void sRecognize_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            string res = Convert.ToString(e.Result.Text);
            if (res == "exit")
            {
                Application.Exit();
            }
            else if (res != "")
            {
                textBox1.Text = textBox1.Text + " " + res;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            sRecognize.RecognizeAsyncStop();
            button2.Enabled = true;
            button3.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pBuilder.ClearContent();
            pBuilder.AppendText(textBox1.Text);
            sSynth.Speak(pBuilder);
        }
    }
}
