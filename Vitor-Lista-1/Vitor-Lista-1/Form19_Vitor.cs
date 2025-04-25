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
    public partial class Form19_Vitor : Form
    {
        public Form19_Vitor()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
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
                int dd, aa, mm, inv;
                dd = Convert.ToInt32(textBox1.Text);
                aa = Convert.ToInt32(textBox3.Text);
                mm = Convert.ToInt32(textBox2.Text);
                inv = (mm*10000)+(aa*100)+dd;
                label3.Text = inv.ToString();
            } catch(FormatException)
            {
                MessageBox.Show("Insira os dados para a execução.", "Error",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
