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
    public partial class Form11_Vitor : Form
    {
        public Form11_Vitor()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int num, quad, cub;
                num = Convert.ToInt32(textBox1.Text);
                quad = num * num;
                cub = num * num * num;
                label3.Text = quad.ToString();
                label6.Text = cub.ToString();
            } catch (FormatException)  
            {
                MessageBox.Show("Insira os dados para a execução.", "Error",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            label3.Text = "";
            label6.Text = "";
        }
    }
}
