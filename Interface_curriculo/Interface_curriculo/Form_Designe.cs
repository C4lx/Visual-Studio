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
    public partial class TxtInterface : Form
    {
        public TxtInterface()
        {
            InitializeComponent();
        }


        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }


        private void textBox3_TextChanged(object sender, EventArgs e)
        {

            if (Util.validarEMAIL(txtEmail.Text))
            {
                txtEmail.BackColor = Color.AliceBlue;
            }
            else
            {
                txtEmail.BackColor = Color.LightGray;

            }

        }

        private void TxtDatanasc_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (txtDatanasc.Text == "")
            {
                txtDatanasc.BackColor = Color.LightGray;
            }
            else
            {
                txtDatanasc.BackColor = Color.AliceBlue;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (validarForm())
            {
                string message = "Deseja salvar o currículo?";
                string title = "Salvar";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    string texto = salvarCurriculo();

                    var textoCripto = Util.Criptografar(texto, UsuarioLogado.Instance().Senha);

                    if (!Directory.Exists(UsuarioLogado.GetCaminhoPastaUsuario()))
                        Directory.CreateDirectory(UsuarioLogado.GetCaminhoPastaUsuario());

                    File.WriteAllText(UsuarioLogado.GetCaminhoPastaUsuario() + @"\curriculo-" + txtNome.Text + ".txt", textoCripto);
                    Limparform();
                }
                else
                {

                }

            }
        }
        private string salvarCurriculo()
        {
            var linha = "Nome: " + txtNome.Text + "; " + "\n" +
                       "Sobrenome: " + txtSobren.Text + "; " + "\n" +
                       "Data de nascimento: " + txtDatanasc.Text.Substring(0, 2) + "/" + txtDatanasc.Text.Substring(2, 2) + "/" + txtDatanasc.Text.Substring(4, 4) + "; " + "\n" +
                       "Email:" + txtEmail.Text + "; " + "\n" +
                       "Telefone: " + txtTelef.Text + "; " + "\n" +
                       "Logradouro: " + txtLograd.Text + "; " + "\n" +
                       "CEP: " + txtCep.Text + "; " + "\n" +
                       "Número: " + txtremPret.Text + "; " + "\n" +
                       "Bairro: " + txtBairro.Text + "; " + "\n" +
                       "Cidade: " + txtCidade.Text + "; " + "\n" +
                       "UF: " + txtUF.Text + ";" + "\n" +
                       "Primeiro emprego? " + txtprimEmpreg.Text + "; " + "\n" +
                       "Interesse em trbalho remoto: " + txttrabRemot.Text + "; " + "\n" +
                       "Remunerãção pretendida? " + txtNum.Text + "; " + "\n" +
                       "Tem site/blog? " + txtSite.Text + "; " + "\n" +
                       txtInfsite.Text + "; " + "\n" +
                       "Qualidades: " + txtQualid.Text + "; "  + textBox1.Text  + textBox2.Text + textBox3.Text + "\n" +
                       "Cursos: " + txtCursos.Text + ";" + textBox4.Text;

            MessageBox.Show(linha);

            return linha;
            //using (StreamWriter arquivo = new StreamWriter(@"C:\\out\\curriculo.txt", true))
            //    arquivo.WriteLine(linha);
        }
        private void Limparform()
        {
            txtNome.Text = "";
            txtSobren.Text = "";
            txtDatanasc.Text = "";
            txtEmail.Text = "";
            txtTelef.Text = "";
            txtLograd.Text = "";
            txtCep.Text = "";
            txtremPret.Text = "";
            txtBairro.Text = "";
            txtCidade.Text = "";
            txtUF.Text = ";";
            txtprimEmpreg.SelectedIndex = -1;
            txttrabRemot.SelectedIndex = -1;
            txtNum.Text = "";
            txtSite.SelectedIndex = -1;
            txtInfsite.Text = "";
            txtQualid.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            txtCursos.Text = "";
            textBox4.Text = "";
        }



        private void btnSalvar_Click(object sender, EventArgs e)
        {


        }

        private bool validarForm()
        {
            bool formValido = true;
            if (txtNome.Text == "")
            {
                MessageBox.Show("Informe o seu nome");
                txtNome.Focus();
                formValido = false;
            }
            else if (txtSobren.Text == "")
            {
                MessageBox.Show("Informe o seu sobrenome");
                txtSobren.Focus();
                formValido = false;
            }
            else if (txtDatanasc.Text == "")
            {
                MessageBox.Show("Informe sua data de nascimento");
                txtDatanasc.Focus();
                formValido = false;
            }
            else if (txtEmail.Text == "")
            {
                MessageBox.Show("Informe seu email");
                txtEmail.Focus();
                formValido = false;
            }
            else if (txtTelef.Text == "")
            {
                MessageBox.Show("Informe seu telefone");
                txtTelef.Focus();
                formValido = false;
            }
            else if (txtLograd.Text == "")
            {
                MessageBox.Show("Informe seu logradouro");
                txtLograd.Focus();
                formValido = false;
            }
            else if (txtCep.Text == "")
            {
                MessageBox.Show("Informe seu cep");
                txtCep.Focus();
                formValido = false;
            }
            else if (txtremPret.Text == "")
            {
                MessageBox.Show("Informe o número");
                txtremPret.Focus();
                formValido = false;
            }
            else if (txtBairro.Text == "")
            {
                MessageBox.Show("Informe seu bairro");
                txtBairro.Focus();
                formValido = false;
            }
            else if (txtCidade.Text == "")
            {
                MessageBox.Show("Informe sua cidade");
                txtCidade.Focus();
                formValido = false;
            }
            else if (txtUF.Text == "")
            {
                MessageBox.Show("Informe seu UF");
                txtUF.Focus();
                formValido = false;
            }
            else if (txtprimEmpreg.Text == "")
            {
                MessageBox.Show("Informe se é seu primeiro emprego");
                txtprimEmpreg.Focus();
                formValido = false;
            }
            else if (txttrabRemot.Text == "")
            {
                MessageBox.Show("Informe seu interesse");
                txttrabRemot.Focus();
                formValido = false;
            }
            else if (txtNum.Text == "")
            {
                MessageBox.Show("Informe sua remuneração");
                txtNum.Focus();
                formValido = false;
            }
            else if (txtSite.Text == "")
            {
                MessageBox.Show("Informe se possui site");
                txtSite.Focus();
                formValido = false;
            }
            else if (txtQualid.Text == "")
            {
                MessageBox.Show("Informe suas qualidades");
                txtQualid.Focus();
                formValido = false;
            }
            else if (textBox1.Text == "")
            {
                MessageBox.Show("Informe suas qualidades");
                textBox1.Focus();
                formValido = false;
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Informe suas qualidades");
                textBox2.Focus();
                formValido = false;
            }
            else if (txtCursos.Text == "")
            {
                MessageBox.Show("Informe seus cursos");
                txtCursos.Focus();
                formValido = false;
            }
            else
            {
                formValido = true;
            }
            return formValido;
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            if(txtNome.Text == "")
            {
                txtNome.BackColor = Color.LightGray;
            }
            else
            {
                txtNome.BackColor =  Color.AliceBlue;
            }
            

        }

        private void txtSobren_TextChanged(object sender, EventArgs e)
        {
            if (txtSobren.Text == "")
            {
                txtSobren.BackColor = Color.LightGray;
            }
            else
            {
                txtSobren.BackColor = Color.AliceBlue;
            }
        }

        private void txtTelef_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (txtTelef.Text == "")
            {
                txtTelef.BackColor = Color.LightGray;
            }
            else
            {
                txtTelef.BackColor = Color.AliceBlue;
            }
        }

        private void txtCep_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (txtCep.Text == "")
            {
                txtCep.BackColor = Color.LightGray;
            }
            else
            {
                txtCep.BackColor = Color.AliceBlue;
            }
        }

        private void txtBairro_TextChanged(object sender, EventArgs e)
        {
            if (txtBairro.Text == "")
            {

                txtBairro.BackColor = Color.LightGray;
            }
            else
            {
                txtBairro.BackColor = Color.AliceBlue;
            }
        }

        private void txtNum_TextChanged(object sender, EventArgs e)
        {
            if (txtremPret.Text == "")
            {
                txtremPret.BackColor = Color.LightGray;
            }
            else
            {
                txtremPret.BackColor = Color.AliceBlue;
            }
        }

        private void txtLograd_TextChanged(object sender, EventArgs e)
        {
            if (txtLograd.Text == "")
            {
                txtLograd.BackColor = Color.LightGray;
            }
            else
            {
                txtLograd.BackColor = Color.AliceBlue;
            }
        }

        private void txtCidade_TextChanged(object sender, EventArgs e)
        {
            if (txtCidade.Text == "")
            {
                txtCidade.BackColor = Color.LightGray;
            }
            else
            {
                txtCidade.BackColor = Color.AliceBlue;
            }
        }

        private void txtUF_TextChanged(object sender, EventArgs e)
        {
            if (txtUF.Text == "")
            {
                txtUF.BackColor = Color.LightGray;
            }
            else
            {
                txtUF.BackColor = Color.AliceBlue;
            }
        }

        private void txtprimEmpreg_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtprimEmpreg.Text == "")
            {
                txtprimEmpreg.BackColor = Color.LightGray;
            }
            else
            {
                txtNome.BackColor = Color.AliceBlue;
            }
        }

        private void txttrabRemot_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txttrabRemot.Text == "")
            {
                txttrabRemot.BackColor = Color.LightGray;
            }
            else
            {
                txttrabRemot.BackColor = Color.AliceBlue;
            }
        }

        private void txtremPret_TextChanged(object sender, EventArgs e)
        {
            if (txtNum.Text == "")
            {
                txtNum.BackColor = Color.LightGray;
            }
            else
            {
                txtNum.BackColor = Color.AliceBlue;
            }
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void txtInfsite_TextChanged(object sender, EventArgs e)
        {
            if (Util.validarSite_Blog(txtInfsite.Text))
            {
                txtInfsite.BackColor = Color.AliceBlue;
            }
            else
            {
                txtInfsite.BackColor = Color.LightGray;
            }

        }

        private void txtSair_Click(object sender, EventArgs e)
        {
            if (Application.OpenForms.Count == 0)
            {
                Application.Exit();
            }
            else
            {
                foreach (Form formAberto in Application.OpenForms)
                {
                    this.Hide();

                    if (formAberto is RfmMenu)
                    {
                        formAberto.Show();
                        break;
                    }
                }
            }
        }

        private void TxtInterface_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.BackColor = Color.LightGray;
            }
            else
            {
                textBox1.BackColor = Color.AliceBlue;
            }
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.BackColor = Color.LightGray;
            }
            else
            {
                textBox2.BackColor = Color.AliceBlue;
            }
        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.BackColor = Color.LightGray;
            }
            else
            {
                textBox3.BackColor = Color.AliceBlue;
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.BackColor = Color.LightGray;
            }
            else
            {
                textBox4.BackColor = Color.AliceBlue;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

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
                    if (formAberto is RfmMenu)
                    {
                        formAberto.Show();
                        break;
                    }
                }
            }
        }

        private void txtNum_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if (txtremPret.Text == "")
            {
                txtremPret.BackColor = Color.LightGray;
            }
            else
            {
                txtremPret.BackColor = Color.AliceBlue;
            }
        }
    }
}
