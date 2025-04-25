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
    public partial class Form17_Vitor: Form
    {
        public Form17_Vitor()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            label7.Text = "";
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int int1, int2, quo, res;
                int1 = Convert.ToInt32(textBox1.Text);
                int2 = Convert.ToInt32(textBox2.Text);
                quo = int1 / int2;
                res = int1 % int2;
                label3.Text = quo.ToString();
                label7.Text = res.ToString();
            }
            catch (FormatException) { 
                MessageBox.Show("Insira os dados para a execução. Escreva apenas números inteiros.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Form17_Vitor_Load(object sender, EventArgs e)
        {

        }
    }
}
