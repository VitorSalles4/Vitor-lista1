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
    public partial class Form18_Vitor : Form
    {
        public Form18_Vitor()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
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
                double salaB, salaL;
                salaB = Convert.ToDouble(textBox1.Text);
                salaL = salaB - (salaB * 10 / 100);
                salaL = salaL - (salaL * 5 / 100);
                label3.Text = salaL.ToString();
            } catch (FormatException )
            {
                MessageBox.Show("Insira os dados para a execução.", "Error",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
