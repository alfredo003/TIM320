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

namespace TIM320
{
    public partial class AC_falar : Form
    {
        public AC_falar()
        {
            InitializeComponent();
        }
        private static SpeechSynthesizer sp = new SpeechSynthesizer();
        private static SpeechRecognitionEngine engine = new SpeechRecognitionEngine();

        private void AC_falar_Load(object sender, EventArgs e)
        {
            try
            {
                
                //SpeechRecognitionEngine engine = new SpeechRecognitionEngine();
                engine.SetInputToDefaultAudioDevice();
                sp = new SpeechSynthesizer();
                sp.SetOutputToDefaultAudioDevice();
                string[] conversas = { "olá", "boa noite" };
                Choices c_conversas = new Choices(conversas);

                GrammarBuilder gb_conversas = new GrammarBuilder();
                gb_conversas.Append(c_conversas);

                Grammar g_conversas = new Grammar(gb_conversas);
                g_conversas.Name = "conversas";

                string[] sistema = { "que horas são", "abrir" };
                Choices c_sistema = new Choices(sistema);

                GrammarBuilder gb_sistema = new GrammarBuilder();
                gb_sistema.Append(c_sistema);

                Grammar g_sistema = new Grammar(gb_sistema);
                g_sistema.Name = "sistema";

                Console.WriteLine("<==========================");
                engine.LoadGrammar(g_conversas);
                engine.LoadGrammar(g_sistema);

                engine.SpeechRecognized += rec;
                Console.WriteLine("==========================>");

                engine.RecognizeAsync(RecognizeMode.Multiple);
                //engine.RecognizeAsync(RecognizeMode.Multiple);
                sp.SelectVoiceByHints(VoiceGender.Male);
                
            }
            catch(Exception)
            {
                MessageBox.Show("Sem Suporte para API.");
            }
        }

        static void rec(object s, SpeechRecognizedEventArgs e)
        {
             Speak("Diga alguma coisa");
            if (e.Result.Confidence >= 0.4f)
            {
                Speak("disseste: "+e.Result.Text);

                if (e.Result.Text == "tudo bem")
                {
                    Speak("Tudo Bem Obrigado ");
                }else if(e.Result.Text == "quem es")
                {
                    Speak("Sou TIM320 ");
                }
                else if (e.Result.Text == "o que é TIM320")
                {
                    Speak("TIM320 é uma ferramenta de Inteligencia artificial repartido em Modulos");
                }
            }
            else
            {
                Speak("Não consigo ouvir correctamente porfavor repita.");
            }
        }

        public static void Speak(string text)
        {
            sp.SpeakAsyncCancelAll();
            sp.SpeakAsync(text);
        }
    }
}
