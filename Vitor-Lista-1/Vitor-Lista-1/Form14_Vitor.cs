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
    public partial class Form14_Vitor: Form
    {
        public Form14_Vitor()
        {
            InitializeComponent();
        }

        private void Form14_Vitor_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            label3.Text = "";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double num1, num2, media;
                num1 = Convert.ToDouble(textBox1.Text);
                num2 = Convert.ToDouble(textBox2.Text);
                media = (num1 + num2) / 2;
                label3.Text = media.ToString();
            } catch(FormatException)
            {
                MessageBox.Show("Insira os dados para a execução.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
    }
}
}
