using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {

        decimal valor1 = 0, valor2 = 0;
        string operacao = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void txtBt0_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
        }

        private void txtBt1_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

        private void txtBt2_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        private void txtBt03_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        private void txtBt4_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        private void txtBt05_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        private void txtBt6_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        private void txtBt07_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        private void txtBt08_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        private void txtBt09_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }

        private void txtVitgula_Click(object sender, EventArgs e)
        {
            txtResultado.Text += ".";

        }

        private void txtEnter_Click(object sender, EventArgs e)
        {
            valor2 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            if (operacao == "SOMA")
            {
                txtResultado.Text = Convert.ToString(valor1 + valor2);
            }
            else if (operacao == "SUB")
            {
                txtResultado.Text = Convert.ToString(valor1 - valor2);
            }
            else if (operacao == "MULT")
            {
                txtResultado.Text = Convert.ToString(valor1 * valor2);
            }
            else
            {
                txtResultado.Text = Convert.ToString(valor1 / valor2);
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtSub_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            txtResultado.Text = "";
            operacao = "SUB";
            lblOperacao.Text = "-";
        }

        private void txtDivisao_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            txtResultado.Text = "";
            operacao = "DIV";
            lblOperacao.Text = "/";
        }

        private void txtMultp_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            txtResultado.Text = "";
            operacao = "MULT";
            lblOperacao.Text = "*";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            valor1 = 0;
            valor2 = 0;
            lblOperacao.Text = "";
        }

        private void txtAdicao_Click(object sender, EventArgs e)
        {
            valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
            txtResultado.Text = "";

            operacao = "SOMA";
            lblOperacao.Text = "+";
        }
    }



}
