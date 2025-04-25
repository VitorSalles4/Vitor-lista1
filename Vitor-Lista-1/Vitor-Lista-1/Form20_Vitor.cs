using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vitor_Lista_1
{
    public partial class Form20_Vitor : Form
    {
        public Form20_Vitor()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int s, ddd;
                string aa;
                aa = textBox1.Text;
                ddd = Convert.ToInt32(textBox3.Text);
                s = Convert.ToInt32(textBox2.Text);

                if ( s == 1 ) {
                    label3.Text = (s+"º Semestre de "+ aa);
                } else if ( s == 2 ) {
                    label3.Text = (s+"º Semestre de " + aa);
                } else { MessageBox.Show("Insira no semestre 1 ou 2.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);  }
                
            } catch(FormatException) {
                MessageBox.Show("Insira o cadastro corretamente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            label3.Text = "";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Form20_Vitor_Load(object sender, EventArgs e)
        {

        }
    }
}
