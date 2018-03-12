using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Speech.Synthesis;

namespace Fala_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SpeechSynthesizer speaker = new SpeechSynthesizer();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnFalarTexto_Click(object sender, RoutedEventArgs e)
        {
            if (!txtTexto.Text.Equals(string.Empty))
            {
                speaker.SpeakAsync(txtTexto.Text);
            }
            else
            {
                MessageBox.Show("Informe o texto para falar.");
            }

        }

        private void btnFalarData_Click(object sender, RoutedEventArgs e)
        {
            speaker.SpeakAsync("Today is " + DateTime.Now.ToShortDateString());
        }

        private void btnFalarHora_Click(object sender, RoutedEventArgs e)
        {
            speaker.SpeakAsync("The time is " + DateTime.Now.ToShortTimeString());
        }

        private void btnFalarNome_Click(object sender, RoutedEventArgs e)
        {
            speaker.SpeakAsync("My name is " + speaker.Voice.Name);

        }

        private void sldVolume_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            speaker.Volume = (int)sldVolume.Value;

        }

        private void sldVelocidade_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            speaker.Rate = (int)(int)sldVelocidade.Value;
        }
   
    }
}
