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
    public partial class Form21_Vitor : Form
    {
        public Form21_Vitor()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            label3.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string nome, sobrenome;
                nome = textBox1.Text;
                sobrenome = textBox2.Text;
                label3.Text = nome + " " + sobrenome;
            }
            catch (FormatException)
            {
                MessageBox.Show("Insira os dados para a execução.", "Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        private void Form21_Vitor_Load(object sender, EventArgs e)
        {

        }
    }
}
