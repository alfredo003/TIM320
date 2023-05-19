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
using System.Diagnostics;

namespace TIM320
{
    public partial class AC_escrever : Form
    {
        public AC_escrever()
        {
            InitializeComponent();
        }
        SpeechSynthesizer sistemaFala = new SpeechSynthesizer();
        private void button1_Click(object sender, EventArgs e)
        {
            string comando = textBox3.Text;

            if (comando.ToLower() == "sair")
            {
                sistemaFalar("Saindo...");
                Application.Exit();
            }else if (comando.ToLower() == "quem é você" || comando.ToLower() == "quem e voce")
            {
                sistemaFalar("Eu Sou TIM320. seu assistente virtual");
            }
            else if (comando.ToLower() == "quem o criou" || comando.ToLower() == "quem te criou")
            {
                sistemaFalar("Fui criado por Isidro Manuel");
            }
            else if (comando.ToLower() == "em que data" || comando.ToLower() == "em que data foste criado")
            {
                sistemaFalar("Fui Criado nos meiados de 1 a 20 de julho de 2018");
            }
            else if (comando.ToLower() == "que horas são" || comando.ToLower() == "que horas sao")
            {
                sistemaFalar(DateTime.Now.ToShortTimeString());
            }
            else if (comando.ToLower() == "que dia é hoje" || comando.ToLower() == "que dia e hoje")
            {
                sistemaFalar(DateTime.Now.ToShortTimeString());
            }
            else if (comando.ToLower() == "abrir calculadora")
            {
                sistemaFalar("Abrindo Calculadora");
                System.Diagnostics.Process.Start("calc");
            }
            else if (comando.ToLower() == "abrir explorador" || comando.ToLower() == "abrir explorador de arquivos")
            {
                sistemaFalar("Abrindo Explorador de Arquivo");
                System.Diagnostics.Process.Start("explorer");
            }
            else if (comando.ToLower() == "abrir o navegador")
            {
                System.Diagnostics.Process.Start("MicrosoftEdge");
            }
            else if (comando.ToLower() == "abrir tradutor")
            {
                sistemaFalar("Abrindo Tradutor");
                Dicionario tradutor = new Dicionario();
                tradutor.Show();
                this.Visible = false;
            }
            else
              
            {
                sistemaFalar("Comando Inválido");
            }
        }

        public void sistemaFalar(string text)
        {
            sistemaFala.SpeakAsyncCancelAll();
            sistemaFala.SpeakAsync(text);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
