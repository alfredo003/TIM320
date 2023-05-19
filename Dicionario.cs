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


namespace TIM320
{
    public partial class Dicionario : Form
    {
        public Dicionario()
        {
            InitializeComponent();
        }
        SpeechSynthesizer sistemaFala = new SpeechSynthesizer();
        private void button1_Click(object sender, EventArgs e)
        {
            string textoTraduzir = tradutorTexto.Text;

            if (textoTraduzir.ToLower() == "eu")
            {
                sistemaFalar("I");
            }else if(textoTraduzir.ToLower() == "estudante")
            {
                sistemaFalar("studant");
            }
            else if (textoTraduzir.ToLower() == "vida")
            {
                sistemaFalar("life");
            }
            else if (textoTraduzir.ToLower() == "agora")
            {
                sistemaFalar("now");
            }
            else if (textoTraduzir.ToLower() == "aniversário")
            {
                sistemaFalar("birth day");
            }
        }
        public void sistemaFalar(string text)
        {
            sistemaFala.SpeakAsyncCancelAll();
            sistemaFala.SpeakAsync(text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string textoTraduzir = tradutorTexto.Text;

            if (textoTraduzir.ToLower() == "ame")
            {
                sistemaFalar("I");
            }
            else if (textoTraduzir.ToLower() == "ove")
            {
                sistemaFalar("You");
            }
            else if (textoTraduzir.ToLower() == "sair")
            {
                sistemaFalar("Saindo do sistema , Out in the System");
                Application.Exit();
            }
        }
    }
}
