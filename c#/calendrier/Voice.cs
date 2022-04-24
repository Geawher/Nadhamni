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
namespace calendrier1
{
    public partial class Voice : Form
    {
        SpeechRecognitionEngine recEngine = new SpeechRecognitionEngine(new System.Globalization.CultureInfo("en-US"));
        SpeechRecognitionEngine recEngine1 = new SpeechRecognitionEngine(new System.Globalization.CultureInfo("en-US"));
        public Voice()
        {
            InitializeComponent();
        }

        private void Voice_Load(object sender, EventArgs e)
        {
            Grammar dictationGrammar = new DictationGrammar();
            dictationGrammar.Name = "default dictation";
            dictationGrammar.Enabled = true;

            recEngine.LoadGrammar(dictationGrammar);
            recEngine.SetInputToDefaultAudioDevice();
            recEngine.SpeechRecognized += recEngine_SpeechRecognized;

            Grammar dictationGrammar1 = new DictationGrammar();
            dictationGrammar.Name = "default dictation";
            dictationGrammar.Enabled = true;

            recEngine1.LoadGrammar(dictationGrammar1);
            recEngine1.SetInputToDefaultAudioDevice();
            recEngine1.SpeechRecognized += recEngine1_SpeechRecognized;
        }
        void recEngine_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            txt_name.Text += e.Result.Text + "\t";
        }

        void recEngine1_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            txt_loc.Text += e.Result.Text + "\t";
        }


        private void btn_voc_name_Click(object sender, EventArgs e)
        {
            recEngine.RecognizeAsync(RecognizeMode.Single);
            btn_mute_name.Enabled = true;
        }

        private void btn_mute_name_Click(object sender, EventArgs e)
        {
            recEngine.RecognizeAsyncStop();
            btn_mute_name.Enabled = false;
        }

        private void btn_voc_loc_Click(object sender, EventArgs e)
        {
            recEngine1.RecognizeAsync(RecognizeMode.Single);
            btn_mute_loc.Enabled = true;

        }

        private void btn_mute_loc_Click(object sender, EventArgs e)
        {
            recEngine1.RecognizeAsyncStop();
            btn_mute_loc.Enabled = false;
        }

        private void btn_Click(object sender, EventArgs e)
        {

        }
    }
}
