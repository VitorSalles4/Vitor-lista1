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
    public partial class Form6_Vitor : Form
    {
        public Form6_Vitor()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            label5.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double vol, alt, raio;
            try
            {
                raio = Convert.ToDouble(textBox1.Text); 
                alt = Convert.ToDouble(textBox2.Text);
                vol = (raio * raio) * 3.14159 * alt;
                label5.Text = vol.ToString();
            }
            catch (FormatException) {
                MessageBox.Show("Insira os dados para a execução.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                throw;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form6_Vitor_Load(object sender, EventArgs e)
        {

        }
    }
}
