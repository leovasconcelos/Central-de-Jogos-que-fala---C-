using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EllisMIS.Audio.Transcription.Microsoft;

namespace MicrosoftSpeechToTextExample
{
    public partial class Form1 : Form
    {
        Dictation _transcriber;

        public Form1()
        {
            InitializeComponent();

        }

        private void btnWavFile_Click(object sender, EventArgs e)
        {
            ///Not sure if a .Dispose is needed at all, but threw it in there.
            if (_transcriber != null)
            {
                _transcriber.Dispose();
            }

            _transcriber = new Dictation();
            SetEvents();
            _transcriber.Start("example.wav");
            
        }

        void _transcriber_SpeechHypothesizingEvent(object sender, System.Speech.Recognition.SpeechHypothesizedEventArgs e)
        {
            Console.WriteLine("Speech Recognizing: " + e.Result.Text);
        }

        void transcriber_SpeechRecognizedEvent(object sender, System.Speech.Recognition.SpeechRecognizedEventArgs e)
        {
            Console.WriteLine("Speech Recognized: " + e.Result.Text);
        }

        public void SetEvents()
        {
            _transcriber.SpeechRecognizedEvent -= new Dictation.SpeechRecognizedEventHandler(transcriber_SpeechRecognizedEvent);
            _transcriber.SpeechHypothesizingEvent -= new Dictation.SpeechHypothesizingEventHandler(_transcriber_SpeechHypothesizingEvent);
            _transcriber.SpeechRecognizedEvent += new Dictation.SpeechRecognizedEventHandler(transcriber_SpeechRecognizedEvent);
            _transcriber.SpeechHypothesizingEvent += new Dictation.SpeechHypothesizingEventHandler(_transcriber_SpeechHypothesizingEvent);
        }

        private void btnMic_Click(object sender, EventArgs e)
        {
            ///Not sure if a .Dispose is needed at all, but threw it in there.
            if (_transcriber != null)
            {
                _transcriber.Dispose();
            }

            _transcriber = new Dictation();
            SetEvents();
            _transcriber.Start();
        }

    }
}
