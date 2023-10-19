using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppFinanciamento
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

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalcularJuros_Click(object sender, EventArgs e)
        {
            double taxaDeJurosMensal = (Convert.ToDouble(txtTaxaAnual.Text) / 100) / 12;
            double ValorParcela = Convert.ToDouble(txtValorPrincipal.Text) * (taxaDeJurosMensal / (1 - Math.Pow(1 + taxaDeJurosMensal, - Convert.ToDouble(txtNumParcelas.Text))));
            double TotalPago = ValorParcela * Convert.ToDouble(txtNumParcelas.Text);
            double ValorJuros = TotalPago - Convert.ToDouble(txtValorPrincipal.Text);
            lblValorParcela.Text = "Valor da parcela: " + ValorParcela.ToString("N2");
            lblTotalpago.Text = "Total Pago: " + TotalPago.ToString("N2");
            lblTotalJuros.Text = "Valor em Juros: " + ValorJuros.ToString("N2");

        }
    }
}
