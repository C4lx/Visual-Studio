using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Interface_curriculo
{
    class Util
    {

        public static string CaminhoTxtUsuarios = @"c:\out\Usuarios.txt";




        public static bool validarEMAIL(string email)
        {
            bool Validar = false;
            int Analisar = email.IndexOf("@");
            if (Analisar > 5)
            {
                if (email.IndexOf("@", Analisar + 1) > 0)
                {
                    return Validar;
                }
                int i = email.IndexOf(".", Analisar);
                if (i - 1 > Analisar)
                {
                    if (i + 1 < email.Length)
                    {
                        string r = email.Substring(i + 1, 1);
                        if (r != ".")
                        {
                            Validar = true;
                        }
                    }
                }
            }
            return Validar;
        }



         public static bool validarSite_Blog(string site)
        {
            bool Validar = false;



            if (site.StartsWith("https://") || site.StartsWith("http://"))
            {
                if (site.EndsWith(".com") || site.EndsWith(".com.br"))
                {

                    Validar = true;

                }
                else
                {
                    Console.WriteLine("Seu site deve terminar com '.com' ou '.com.br'.");
                }
            }
            else
            {
                Console.WriteLine("Seu site deve começar com 'https://' ou 'http://.");
            }
            return Validar;
        }

        
        public static string DescriptografarSemSenha(dynamic Message)
        {
            return Descriptografar(Message, "1234");
        }
        public static string CriptografarSemSenha(dynamic Message)
        {
            return Criptografar(Message, "1234");
        }
        public static string Descriptografar(dynamic Message, string senha)
        {
            byte[] Results;
            System.Text.UTF8Encoding UTF8 = new System.Text.UTF8Encoding();
            MD5CryptoServiceProvider HashProvider = new MD5CryptoServiceProvider();
            byte[] TDESKey = HashProvider.ComputeHash(UTF8.GetBytes(senha));
            TripleDESCryptoServiceProvider TDESAlgorithm = new TripleDESCryptoServiceProvider();
            TDESAlgorithm.Key = TDESKey;
            TDESAlgorithm.Mode = CipherMode.ECB;
            TDESAlgorithm.Padding = PaddingMode.PKCS7;
            byte[] DataToDecrypt = Convert.FromBase64String(Message);
            try
            {
                ICryptoTransform Decryptor = TDESAlgorithm.CreateDecryptor();
                Results = Decryptor.TransformFinalBlock(DataToDecrypt, 0, DataToDecrypt.Length);
            }
            finally
            {
                TDESAlgorithm.Clear();
                HashProvider.Clear();
            }
            return UTF8.GetString(Results);
        }
        public static string Criptografar(dynamic Message, string senha)
        {
            byte[] Results;
            System.Text.UTF8Encoding UTF8 = new System.Text.UTF8Encoding();
            MD5CryptoServiceProvider HashProvider = new MD5CryptoServiceProvider();
            byte[] TDESKey = HashProvider.ComputeHash(UTF8.GetBytes(senha));
            TripleDESCryptoServiceProvider TDESAlgorithm = new TripleDESCryptoServiceProvider();
            TDESAlgorithm.Key = TDESKey;
            TDESAlgorithm.Mode = CipherMode.ECB;
            TDESAlgorithm.Padding = PaddingMode.PKCS7;
            byte[] DataToEncrypt = UTF8.GetBytes(Message);
            try
            {
                ICryptoTransform Encryptor = TDESAlgorithm.CreateEncryptor();
                Results = Encryptor.TransformFinalBlock(DataToEncrypt, 0, DataToEncrypt.Length);
            }
            finally
            {
                TDESAlgorithm.Clear();
                HashProvider.Clear();
            }
            return Convert.ToBase64String(Results);
        }
    }

}
