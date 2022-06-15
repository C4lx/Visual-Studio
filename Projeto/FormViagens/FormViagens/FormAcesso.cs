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
using System.Globalization;

namespace FormViagens
{
    public partial class FormAcesso : Form
    {
        public FormAcesso()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Entrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            

            if (File.Exists(Util.CaminhoTxtUsuarios))
            {
                var texto = File.ReadAllText(Util.CaminhoTxtUsuarios);

                foreach (var line in texto.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries))
                {
                    string username = Util.DescriptografarSemSenha(line.Split(';')[0]);
                    string senha = Util.DescriptografarSemSenha(line.Split(';')[1]);

                    if (txtUsuario.Text == username && txtSenha.Text == senha)
                    {
                        UsuarioLogado.Init(username, senha);

                        UsuarioLogado.GetCaminhoServicosUsuario();

                        MessageBox.Show("OBRIGADO POR FAZER PARTE DA NOSSA HISTÓRIA!" + "\n" + "SEJA MUITO BEM-VINDO! ;)");
                        frmHome principal = new frmHome();
                        principal.Show();
                        this.Hide();
                    }

                }
            }



        }

        private void CriarUser_Click(object sender, EventArgs e)
        {
            CriarConta criar = new CriarConta();
            criar.Show();
            this.Hide();
        }

        private void CriarUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
