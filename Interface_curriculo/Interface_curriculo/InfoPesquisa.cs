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
    public partial class InfoPesquisa : Form
    {
       

        //string usuariosCsv = @"c:\out\Login.csv";

       // bool arquivoAberto = false;

        public InfoPesquisa()
        {
            InitializeComponent();
            //ConfigurarTabela();
        }

       

        private void bntOK_Click(object sender, EventArgs e)
        {
            if (ValidarForm())
            {
                if (MessageBox.Show("Deseja salvar os dados?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (SalvarDados())
                        MessageBox.Show("Cadastro salvo com sucesso!", "Salvar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCadastro();
                }
                else
                {
                    MessageBox.Show("Operação cancelada!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }


        private bool ValidarForm()      //valida se o usuario preencheu todos os campos corretamente
        {
            bool formValido;

            if (txtUsuario.Text == "")
            {
                MessageBox.Show("Usuário é obrigatório!");
                txtUsuario.Focus();
                formValido = false;
            }
            else if (txtSsenha.Text == "")
            {
                MessageBox.Show("Senha é obrigatória!");
                txtSsenha.Focus();
                formValido = false;
            }
            else
            {
                formValido = true;
            }             
            return formValido;
        }

       

        private void LimparCadastro()
        {
            lblId.Text = "";
            txtUsuario.Clear();
            txtSsenha.Clear();
        }


       

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
           // GetUser(txtUsuario.Text);
        }

      

       
        private bool SalvarDados()  
        {
            try
            {
                //var ServicoUsuario = Util.criptografarteste(txtUser.Text, UsuarioLogado.Instance().Senha);




                var UserCriptografado = Util.CriptografarSemSenha(txtUsuario.Text);
                var SenhaCriptografado = Util.CriptografarSemSenha(txtSsenha.Text);



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

        

        private void InfoPesquisa_FormClosing(object sender, FormClosingEventArgs e)
        {
           // if (MessageBox.Show("Deseja salvar os dados?", "Salvar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
           //     SalvarDados();
        }

        private void InfoPesquisa_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Application.OpenForms.Count == 0)
            {
                Application.Exit();
            }
            else
            {
                foreach (Form formAberto in Application.OpenForms)
                {
                    if (formAberto is FormLogin)
                    {
                        formAberto.Show();
                        break;
                    }
                }
            }
        }

      

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void InfoPesquisa_Load(object sender, EventArgs e)
        {

        }
    }
}
