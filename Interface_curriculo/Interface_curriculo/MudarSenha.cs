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
    public partial class MudarSenha : Form
    { 
         // string arquivotxt = @"c:\out\Usuarios.txt";
    
        public MudarSenha()
        {
            InitializeComponent();
        }

        private void MudarSenha_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
      
        }

        private void LimparForm()
        {
            txtNewPass.Text = "";
            txtNewPass.Text = "";
        }

        private void txtNewpass_TextChanged(object sender, EventArgs e)
        {



        }

        private void txtNewuser_TextChanged(object sender, EventArgs e)
        {

        }



        private void label4_Click(object sender, EventArgs e)
        {
            
        }



        private void txtSenhaAntiga_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtSenhaOld.Text == UsuarioLogado.Instance().Senha)
            {
                MessageBox.Show("Senha antiga informada corretamente!!", "Você pode mudar sua senha!!");
            }
            else
            {
                MessageBox.Show("Senha antiga informada está incorreta!!", "Você não poderá mudar sua senha!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (txtNewPass.Text != txtNewPassConfirmação.Text)
            {
                MessageBox.Show("As senhas não conferem!!", "Tente novamente!! :( ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Deseja salvar os dados?", "Salvar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    MessageBox.Show("As senhas foram alteradas e salvas com sucesso!!", "salvo com sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    string textoCriptografado = Util.CriptografarSemSenha(txtNewPass.Text);
                    File.AppendAllText(@"c:\out\Usuarios.txt", textoCriptografado + Environment.NewLine);
                }
            } 
    }

    private void txtSenhaAntiga_TextChanged_1(object sender, EventArgs e)
        {

        }

       // private void button2_Click(object sender, EventArgs e)
       // {
       //}

        private void button1_Click_1(object sender, EventArgs e)
        {
            RfmMenu frm = new RfmMenu();
            frm.Show();
            Hide();
        }

        private void lblUser_Click(object sender, EventArgs e)
        {
           // lblUser.Text = UsuarioLogado.Instance().Login;
        }
    }
    }
    
