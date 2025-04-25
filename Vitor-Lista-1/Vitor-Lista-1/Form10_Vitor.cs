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
    public partial class Form10_Vitor : Form
    {
        public Form10_Vitor()
        {
            InitializeComponent();
        }

        private void Form10_Vitor_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                double comprimento, altura, largura, volume;
                comprimento = Convert.ToDouble(textBox1.Text);
                altura = Convert.ToDouble(textBox2.Text);
                largura = Convert.ToDouble(textBox3.Text);
                volume = comprimento * altura * largura;
                label6.Text = volume.ToString();
            } catch (FormatException)
            {
                MessageBox.Show("Insira os dados para a execução.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            label6.Text = "";
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
