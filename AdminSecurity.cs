using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.Unicode;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsAppTest
{
    public partial class AdminSecurity : Form
    {
        public AdminSecurity()
        {
            InitializeComponent();
        }
        public string temp;
        private void button1_Click(object sender, EventArgs e)
        {
            var KeyString = textKeyString.Text;
            temp = KeyString;
            var TextString = textString.Text;
            var data = Convert.ToBase64String(EncryptData(KeyString, TextString));
            textEncryptString.Text = data;
        }


        public static byte[] EncryptData(string KeyString, string TextString)
        {
            byte[] Results;
            System.Text.UTF8Encoding UTF8 = new System.Text.UTF8Encoding();
            MD5CryptoServiceProvider HashProvider = new MD5CryptoServiceProvider();
            byte[] TDESKey = HashProvider.ComputeHash(UTF8.GetBytes(KeyString));
            TripleDESCryptoServiceProvider TDESAlgorithm = new TripleDESCryptoServiceProvider();
            TDESAlgorithm.Key = TDESKey;
            TDESAlgorithm.Mode = CipherMode.ECB;
            TDESAlgorithm.Padding = PaddingMode.PKCS7;
            byte[] DataToEncrypt = UTF8.GetBytes(TextString);
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
            return Results;
        }

        public static byte[] DecryptString(string stringToDecrypt, string hash)
        {
            byte[] Results;
            System.Text.UTF8Encoding UTF8 = new System.Text.UTF8Encoding();
            MD5CryptoServiceProvider HashProvider = new MD5CryptoServiceProvider();
            byte[] TDESKey = HashProvider.ComputeHash(UTF8.GetBytes(hash));
            TripleDESCryptoServiceProvider TDESAlgorithm = new TripleDESCryptoServiceProvider();
            TDESAlgorithm.Key = TDESKey;
            TDESAlgorithm.Mode = CipherMode.ECB;
            TDESAlgorithm.Padding = PaddingMode.PKCS7;
            byte[] DataToDecrypt = Convert.FromBase64String(stringToDecrypt);
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
            return Results;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            System.Text.UTF8Encoding UTF8 = new System.Text.UTF8Encoding();
            var key_String = textKeyString.Text;
            if (temp != key_String)
            {
                textString.Text = "";
            }
            else
            {
                var text_String = textString.Text;
                var encrypt_String = textEncryptString.Text;
                var data = DecryptString(encrypt_String, key_String);
                textString.Text = UTF8.GetString(data);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textKeyString.Text = "";
            textString.Text = "";
            textEncryptString.Text = "";
        }
    }
}
