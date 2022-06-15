using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormViagens
{
    class UsuarioLogado
    {
        public string Login { get; set; }
        public string Senha { get; set; }

        public static string CaminhoUsuariosCsv = @"c:\out\User-";


        public static string GetCaminhoServicosUsuario()
        {
            return CaminhoUsuariosCsv + instance.Login + ".txt";
        }


        static UsuarioLogado instance;



        protected UsuarioLogado()
        {
        }



        // Constructor is 'protected'
        protected UsuarioLogado(string login, string senha)
        {
            Login = login;
            Senha = senha;
        }



        public static UsuarioLogado Init(string login, string senha)
        {
            if (instance == null)
            {
                instance = new UsuarioLogado(login, senha);
            }
            return instance;
        }
        public static UsuarioLogado Instance()
        {
            // Uses lazy initialization.
            // Note: this is not thread safe.
            if (instance == null)
            {
                instance = new UsuarioLogado();
            }
            return instance;
        }
    }
}
