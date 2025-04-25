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
    public partial class Form3_Vitor : Form
    {
        double salario_b, horas_t, valor_h, percentual_desc, total_desc, salario_l;

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            label5.Text = "";
            label7.Text = "";
            label10.Text = "";
        }

        public Form3_Vitor()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                horas_t = Convert.ToDouble(textBox1.Text);
                valor_h = Convert.ToDouble(textBox2.Text);
                salario_b = horas_t * valor_h;
                salario_b = Math.Round(salario_b, 2);
                label5.Text = salario_b.ToString();

                percentual_desc = Convert.ToDouble(textBox3.Text);
                total_desc = (percentual_desc / 100) * salario_b;
                total_desc = Math.Round(total_desc, 2);
                label7.Text = total_desc.ToString();

                salario_b = Convert.ToDouble(label5.Text);
                total_desc = Convert.ToDouble(label7.Text);
                salario_l = salario_b - total_desc;
                salario_b = Math.Round(salario_b, 2);
                label10.Text = salario_l.ToString();
            }
            catch (FormatException)
            {
                MessageBox.Show("Insira os dados para a execução.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                throw;
            }
        }
    }
}
