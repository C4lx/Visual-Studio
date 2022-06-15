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
    public partial class frm2Locais : Form
    {
        public frm2Locais()
        {
            InitializeComponent();
        }

        private void Form2Locais_Load(object sender, EventArgs e)
        {

        }

        private void frm2Locais_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();

           
        }

        private void lblVoltar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (Application.OpenForms.Count == 0)
            {
                Application.Exit();
            }
            else
            {
                foreach (Form formAberto in Application.OpenForms)
                {
                    if (formAberto is frmHome)
                    {
                        formAberto.Show();
                        this.Hide();
                        break;
                    }
                }
            }
        }

        private void lbHotel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm3Pacotes frm3 = new frm3Pacotes();
            frm3.Show();
            this.Hide();
        }

        private void lbPacotes_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormPacote formPacote = new FormPacote();
            formPacote.Show();
            this.Hide();
        }
    }
}
