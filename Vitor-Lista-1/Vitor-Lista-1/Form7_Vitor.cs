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
    public partial class Form7_Vitor : Form
    {
        public Form7_Vitor()
        {
            InitializeComponent();
        }

        private void Form7_Vitor_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double tempoVia, velocidadeMed, distanciaPer, litrosUsa;
                tempoVia = Convert.ToDouble(textBox1.Text);
                velocidadeMed = Convert.ToDouble(textBox2.Text);
                distanciaPer = tempoVia * velocidadeMed;
                litrosUsa = distanciaPer / 12;

                label5.Text = distanciaPer.ToString();
                label6.Text = litrosUsa.ToString();
                label10.Text = tempoVia.ToString();
                label11.Text = velocidadeMed.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Insira os dados para a execução.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            label5.Text = "";
            label6.Text = "";
            label10.Text = "";
            label11.Text = "";
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
