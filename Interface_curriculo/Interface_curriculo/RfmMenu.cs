using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Interface_curriculo
{
    public partial class RfmMenu : Form
    {
        public RfmMenu()
        {
            InitializeComponent();
        }

        private void movim_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TxtInterface rfm = new TxtInterface();
            rfm.Owner = this;
            rfm.Show();
            this.Hide();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {         //adiciona uma pasta para cada novo usuario contendo as informaçoes
            try
            {
                DirectoryInfo d = new DirectoryInfo(UsuarioLogado.GetCaminhoPastaUsuario());  
                FileInfo[] Files = d.GetFiles("*.txt");
                string arquivo = null;
                bool AchouArquivo = false;

                foreach (FileInfo file in Files)
                {
                   if(file.Name.ToUpper().Contains(txtPesquisar.Text.ToUpper()))
                    {
                        arquivo = d.FullName + @"\" + file.Name;
                        AchouArquivo = true;
                    }

                }

                if (AchouArquivo)
                {
                    string texto = File.ReadAllText(arquivo);
                    string TextoMostrarNaTela = "";


                    TextoMostrarNaTela += Util.Descriptografar(texto, UsuarioLogado.Instance().Senha);

                 
                    MessageBox.Show(TextoMostrarNaTela);

                }
                else
                {
                    MessageBox.Show("Nenhum arquivo encontrado com esse nome.");

                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void txtPesquisar_TextChanged(object sender, EventArgs e)
        {

        }

        private void RfmMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Sobre1 frm1 = new Sobre1();
            frm1.Show();
            Hide();
        }

        private void troca_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MudarSenha frm = new MudarSenha();
            frm.Show();
            Hide();
        }
    }
}
