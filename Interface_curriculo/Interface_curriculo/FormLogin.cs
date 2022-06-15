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
    public partial class FormLogin : Form
    { 
      //  string username, senha1;
        public FormLogin()
        {
            InitializeComponent();
        }
        
        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void bntSair_Click_1(object sender, EventArgs e)          
        {
            //fecha o programa
            this.Close();   
        }

        private void bntLogin_Click_1(object sender, EventArgs e)            
        {
            if (File.Exists(Util.CaminhoTxtUsuarios))
            {
                var texto = File.ReadAllText(Util.CaminhoTxtUsuarios);



                foreach (var line in texto.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries))
                {
                    string username = Util.DescriptografarSemSenha(line.Split(';')[0]);
                    string senha = Util.DescriptografarSemSenha(line.Split(';')[1]);



                    if (txbUser.Text == username && txbSenha.Text == senha)
                    {
                        UsuarioLogado.Init(username, senha);

                        MessageBox.Show("Seja bem vindo! " );
                        RfmMenu principal = new RfmMenu();
                        principal.Show();
                        this.Hide();
                    }
                    
                }
            }
        }

        private void txbUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)  
            
        {
        //abriria o acesso para "Crie seu acesso"
            InfoPesquisa rfm = new InfoPesquisa();
            rfm.Show();
            Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Sobre1 frm1 = new Sobre1();
            frm1.Show();
            Hide();
        }
    }
}

