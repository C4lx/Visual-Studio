using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormViagens
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void lbLocal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm2Locais frm1 = new frm2Locais();
            frm1.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //clique erradokk
        }

        private void lbHotel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm3Pacotes frm3 = new frm3Pacotes();
            frm3.Show();
            this.Hide();
        }

        private void lbPacotes_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormPacote frmPacote = new FormPacote();
            frmPacote.Show();
            this.Hide();
        }

        private void bntBusca_Click(object sender, EventArgs e)
        {

        }

        private void frmHome_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {

        }
    }
}
