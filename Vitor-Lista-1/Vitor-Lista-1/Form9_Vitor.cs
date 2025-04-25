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
    public partial class Form9_Vitor : Form
    {
        public Form9_Vitor()
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
            textBox3.Clear();
            textBox4.Clear();
            
            label5.Text = "";
            label6.Text = "";
            label17.Text = "";
            label13.Text = "";
            label10.Text = "";
            label14.Text = "";

            label29.Text = "";
            label26.Text = "";
            label21.Text = "";
            label25.Text = "";
            label22.Text = "";
            label18.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                double A, B, C, D, som1, som2, som3, som4, som5, som6, vez1, vez2, vez3, vez4, vez5, vez6;
                A = Convert.ToDouble(textBox1.Text);
                B = Convert.ToDouble(textBox2.Text);
                C = Convert.ToDouble(textBox4.Text);
                D = Convert.ToDouble(textBox3.Text);
                som1 = A + B;
                som2 = A + C;
                som3 = A + D;
                som4 = C + B;
                som5 = D + B;
                som6 = C + D;
                
                vez1 = A * B;
                vez2 = A * C;
                vez3 = A * D;
                vez4 = C * B;
                vez5 = D * B;
                vez6 = C * D;

                label5.Text = som1.ToString();
                label6.Text = som2.ToString();
                label17.Text = som3.ToString();
                label13.Text = som4.ToString();
                label10.Text = som5.ToString();
                label14.Text = som6.ToString();

                label29.Text = vez1.ToString();
                label26.Text = vez2.ToString();
                label21.Text = vez3.ToString();
                label25.Text = vez4.ToString();
                label22.Text = vez5.ToString();
                label18.Text = vez6.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Insira os dados para a execução.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
