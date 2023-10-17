using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppDolarReal2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double valorDolar = Convert.ToDouble(txtValorReal.Text)/Convert.ToDouble(txtCotacaoDolar.Text);
            lblResultado.Text ="Valor em U$: " + valorDolar.ToString("N2");
        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

        private void txtCotacaoDolar_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
