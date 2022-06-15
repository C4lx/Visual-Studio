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

namespace FormViagens
{
    public partial class CriarConta : Form
    {
        public CriarConta()
        {
            InitializeComponent();
        }

        private void LimparCadastro()
        {
            textUsuario.Clear();
            textSenha.Clear();
        }

        private bool SalvarNovoCadastro()
        {
            try
            {



                var UserCriptografado = Util.CriptografarSemSenha(textUsuario.Text);
                var SenhaCriptografado = Util.CriptografarSemSenha(textSenha.Text);

                File.AppendAllText(Util.CaminhoTxtUsuarios,
                (UserCriptografado + ";" + SenhaCriptografado) + Environment.NewLine);

                return true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Falha ao tentar salvar: " + ex.Message, "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }

        }

        private bool ValidarCadastro()
        {
            bool formValido;

            if (textUsuario.Text == "")
            {
                MessageBox.Show("Por favor, informe um username válido.");
                textUsuario.Focus();
                formValido = false;
            }
            else if (textSenha.Text == "")
            {
                MessageBox.Show("Por favor, informe uma senha válida.");
                textSenha.Focus();
                formValido = false;
            }
            else
            {
                formValido = true;

            }

            return formValido;
        }


        private void Entrar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (ValidarCadastro())
            {
                if (MessageBox.Show("Deseja salvar os dados?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (SalvarNovoCadastro())
                        MessageBox.Show("Cadastro salvo com sucesso!", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCadastro();

                    MessageBox.Show("OBRIGADO POR FAZER PARTE DA NOSSA HISTÓRIA!" + "\n" + "SEJA MUITO BEM-VINDO! ;)");
                    frmHome principal = new frmHome();
                    principal.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Operação cancelada!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
        }

        private void CriarConta_FormClosed(object sender, FormClosedEventArgs e)
        {
            FormAcesso acesso = new FormAcesso();
            acesso.Show();
            this.Hide();
        }
    }
}
