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
    public partial class Form13_Vitor : Form
    {
        public Form13_Vitor()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

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
                int num1, num2, quad;
                num1 = Convert.ToInt32(textBox1.Text);
                num2 = Convert.ToInt32(textBox2.Text);
                quad = (num2 * num2) + (num1 * num1);
                label3.Text = quad.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Insira os dados para a execução.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
