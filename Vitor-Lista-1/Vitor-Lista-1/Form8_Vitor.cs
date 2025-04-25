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
    public partial class Form8_Vitor : Form
    {
        public Form8_Vitor()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            label5.Text = "";
            label6.Text = "";
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int A, B, C;
                A = Convert.ToInt32(textBox1.Text);
                B = Convert.ToInt32(textBox2.Text);
                C = A;
                A = B;
                B = C;
                label5.Text = A.ToString();
                label6.Text = B.ToString();
            } catch (FormatException){
                MessageBox.Show("Insira os dados para a execução.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
