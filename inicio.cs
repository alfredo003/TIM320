using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TIM320
{
    public partial class inicio : Form
    {
        public inicio()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AC_falar menu = new AC_falar();
            menu.Show();
            this.Visible = false;
        }

        private void inicio_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            AC_escrever AC_escrever = new AC_escrever();
            AC_escrever.Show();
            this.Visible = false;
          

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
