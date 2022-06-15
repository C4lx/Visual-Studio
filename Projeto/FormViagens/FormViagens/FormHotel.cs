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
    public partial class frm3Pacotes : Form
    {
        public frm3Pacotes()
        {
            InitializeComponent();
        }

        private void frm3Pacotes_FormClosed(object sender, FormClosedEventArgs e)
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

        private void lbLocal_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frm2Locais frm2 = new frm2Locais();
            frm2.Show();
            this.Hide();
        }

        private void lbHotel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void lbPacotes_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormPacote frmPacote = new FormPacote();
            frmPacote.Show();
            this.Hide();
        }

        private void lblIconeBeta_Click(object sender, EventArgs e)
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

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void lblReservaHotel_Click(object sender, EventArgs e)
        {
            FormReserva frmReserva = new FormReserva();
            frmReserva.Show();
            this.Hide();
        }

        private void lblReserva_Click(object sender, EventArgs e)
        {
            FormReserva frmReserva = new FormReserva();
            frmReserva.Show();
            this.Hide();
        }

        private void lblReserv_Click(object sender, EventArgs e)
        {
            FormReserva frmReserva = new FormReserva();
            frmReserva.Show();
            this.Hide();
        }

        private void lblReser_Click(object sender, EventArgs e)
        {
            FormReserva frmReserva = new FormReserva();
            frmReserva.Show();
            this.Hide();
        }

        private void lblRese_Click(object sender, EventArgs e)
        {
            FormReserva frmReserva = new FormReserva();
            frmReserva.Show();
            this.Hide();
        }

        private void lblRes_Click(object sender, EventArgs e)
        {
            FormReserva frmReserva = new FormReserva();
            frmReserva.Show();
            this.Hide();
        }
    }
}
