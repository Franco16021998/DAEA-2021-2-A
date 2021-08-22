using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {

                int a = Convert.ToInt32(txtNumero1.Text);
                int b = Convert.ToInt32(txtNumero2.Text);
                int c = a + b;
                txtResultado.Text = Convert.ToString(c);               
                
            }

            else if (comboBox1.SelectedIndex == 1)
            {

                int a = Convert.ToInt32(txtNumero1.Text);
                int b = Convert.ToInt32(txtNumero2.Text);
                int c = a - b;
                txtResultado.Text = Convert.ToString(c);

            }

            else if (comboBox1.SelectedIndex == 2)
            {

                int a = Convert.ToInt32(txtNumero1.Text);
                int b = Convert.ToInt32(txtNumero2.Text);
                int c = a * b;
                txtResultado.Text = Convert.ToString(c);

            }

            else if (comboBox1.SelectedIndex == 3)
            {

                int a = Convert.ToInt32(txtNumero1.Text);
                int b = Convert.ToInt32(txtNumero2.Text);
                int c = a / b;
                txtResultado.Text = Convert.ToString(c);

            }

            else if (comboBox1.SelectedIndex == 4)
            {
                string c = "";
                for ( int i = 1; i <= 10; i++)
                {
                    c = c + Math.Sqrt(i) + ",";
                }
               
                txtResultado.Text = Convert.ToString(c);

            }

        }
    }
}
