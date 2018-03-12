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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        private NAudio.Wave.BlockAlignReductionStream stream = null;
        private NAudio.Wave.DirectSoundOut output = null;
        SpeechSynthesizer sSynth = new SpeechSynthesizer();
        SpeechRecognitionEngine sRecognize = new SpeechRecognitionEngine();
        string path1 = @"D:\Músicas";


        private void btnAcdc_Click(object sender, EventArgs e)
        {
            sRecognize.RecognizeAsyncStop();
            DisposeWave();
            btnAcdc.Enabled = false;
            btnAcdc.Enabled = true;
            Choices slist = new Choices();
            slist.Add(new string[] { "in", "back", "struck", "thunder", "black" });
            Grammar gr = new Grammar(new GrammarBuilder(slist));
            try
            {
                sRecognize.RequestRecognizerUpdate();
                sRecognize.LoadGrammar(gr);
                sRecognize.SpeechRecognized += sRecognize_SpeechRecognized;
                sRecognize.SetInputToDefaultAudioDevice();
                sRecognize.RecognizeAsync(RecognizeMode.Multiple);
            }
            catch
            {
                return;
            }
        }

        private void sRecognize_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            if (e.Result.Text == "exit")
            {
                Application.Exit();
            }
            if (e.Result.Text == "pausa")
            {
                btnPausar.PerformClick();
            }

            if (e.Result.Text == "limpa")
            {
                textBox1.Text = null;
            }
            if (e.Result.Text == "charliebrown")
            {
                btnCharlieBrown.PerformClick();
            }

            if (e.Result.Text == "reproduzir")
            {
                string path2 = textBox1.Text;
                string combination = Path.Combine(path1, path2);
                var hellow2 = File.Open(combination, FileMode.Open);
                NAudio.Wave.WaveStream pcm = NAudio.Wave.WaveFormatConversionStream.CreatePcmStream(new NAudio.Wave.Mp3FileReader(hellow2));
                stream = new NAudio.Wave.BlockAlignReductionStream(pcm);
                output = new NAudio.Wave.DirectSoundOut();
                output.Init(stream);
                output.Play();
            }
            else
            {
                textBox1.Text = textBox1.Text + " " + e.Result.Text.ToString();
            }

        }

        private void btnPausar_Click(object sender, EventArgs e)
        {
            if (output != null)
            {
                if (output.PlaybackState == NAudio.Wave.PlaybackState.Playing) output.Pause();
                else if (output.PlaybackState == NAudio.Wave.PlaybackState.Paused) output.Play();
            }
        }


        private void DisposeWave()
        {
            if (output != null)
            {
                if (output.PlaybackState == NAudio.Wave.PlaybackState.Playing) output.Stop();
                output.Dispose();
                output = null;
            }
            if (stream != null)
            {
                stream.Dispose();
                stream = null;
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DisposeWave();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var hellow = File.Open(@"C:\Users\IFSP\Desktop\Reprodutor - Renato\Bem Vindo(2).mp3", FileMode.Open);
            NAudio.Wave.WaveStream pcm = NAudio.Wave.WaveFormatConversionStream.CreatePcmStream(new NAudio.Wave.Mp3FileReader(hellow));
            stream = new NAudio.Wave.BlockAlignReductionStream(pcm);
            output = new NAudio.Wave.DirectSoundOut();
            output.Init(stream);
            output.Play();
            Choices slist3 = new Choices();
            slist3.Add(new string[] { "acdc", "charliebrown", "exit" });
            Grammar gr3 = new Grammar(new GrammarBuilder(slist3));
            try
            {
                sRecognize.RequestRecognizerUpdate();
                sRecognize.LoadGrammar(gr3);
                sRecognize.SpeechRecognized += sRecognize_SpeechRecognized;
                sRecognize.SetInputToDefaultAudioDevice();
                sRecognize.RecognizeAsync(RecognizeMode.Multiple);
            }
            catch
            {
                return;
            }

        }

        private void btnCharlieBrown_Click(object sender, EventArgs e)
        {
            sRecognize.RecognizeAsyncStop();
            DisposeWave();
            textBox1.Text = null;
            var hellow = File.Open(@"C:\Users\IFSP\Desktop\Reprodutor - Renato\Reproduzir.mp3", FileMode.Open);
            NAudio.Wave.WaveStream pcm = NAudio.Wave.WaveFormatConversionStream.CreatePcmStream(new NAudio.Wave.Mp3FileReader(hellow));
            stream = new NAudio.Wave.BlockAlignReductionStream(pcm);
            output = new NAudio.Wave.DirectSoundOut();
            output.Init(stream);
            output.Play();
            btnCharlieBrown.Enabled = false;
            btnCharlieBrown.Enabled = true;
            Choices slist2 = new Choices();
            slist2.Add(new string[] { "Vicios", "e", "virtudes", "tudo", "mudar", "reproduzir", "limpa" });
            Grammar gr2 = new Grammar(new GrammarBuilder(slist2));
            try
            {
                sRecognize.RequestRecognizerUpdate();
                sRecognize.LoadGrammar(gr2);
                sRecognize.SpeechRecognized += sRecognize_SpeechRecognized;
                sRecognize.SetInputToDefaultAudioDevice();
                sRecognize.RecognizeAsync(RecognizeMode.Multiple);
            }
            catch
            {
                return;
            }
        }

        private void btnEscolha_Click(object sender, EventArgs e)
        {
            sRecognize.RecognizeAsyncStop();
            OpenFileDialog abrir = new OpenFileDialog();
            abrir.Filter = "Mp3 File (*.mp3)| *.mp3";
            abrir.InitialDirectory = @"D:\Músicas";
            if (abrir.ShowDialog() != DialogResult.OK) return;
            DisposeWave();
            NAudio.Wave.WaveStream pcm = NAudio.Wave.WaveFormatConversionStream.CreatePcmStream(new NAudio.Wave.Mp3FileReader(abrir.FileName));
            stream = new NAudio.Wave.BlockAlignReductionStream(pcm);
            output = new NAudio.Wave.DirectSoundOut();
            output.Init(stream);
            output.Play();
           
        }
    }
}