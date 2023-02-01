using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Numerics;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;

namespace protect_inf_LR1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        //ШИФРОВКА
        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            if (sourceFilePathTextBox.Text.Length > 0)
            {
                SHA256 alg = SHA256.Create();
                string message = File.ReadAllText(sourceFilePathTextBox.Text);
                
                byte[] data = Encoding.ASCII.GetBytes(message);
                byte[] hash = alg.ComputeHash(data);
                
                RSAParameters sharedParameters;
                byte[] signedHash;
                byte[] publicKey;
                byte[] privateKey;
               
                using (RSA rsa = RSA.Create())
                {
                    rsa.KeySize = 1024;
                    sharedParameters = rsa.ExportParameters(true);

                    var keys = rsa.ToXmlString(true);
                    
                    File.WriteAllText("output", keys);

                    RSAPKCS1SignatureFormatter rSAPKCS1SignatureFormatter = new RSAPKCS1SignatureFormatter(rsa);
                    RSAPKCS1SignatureFormatter rsaFormatter = rSAPKCS1SignatureFormatter;
                    rsaFormatter.SetHashAlgorithm(nameof(SHA256));

                    signedHash = rsaFormatter.CreateSignature(hash);

                    File.WriteAllBytes("Signed", signedHash);
                    MessageBox.Show("Файл підписано.");
                }
            }
            else
                MessageBox.Show("Виберіть файл для шифрування");

        }

        //ДЕШИФРОВКА
        private void buttonDecipher_Click(object sender, EventArgs e)
        {
            if ((sourceFilePathTextBox.Text.Length > 0) && (signFilePathTextBox.Text.Length > 0))
            {
                SHA256 alg = SHA256.Create();
                
                byte[] signedHash = File.ReadAllBytes(signFilePathTextBox.Text);
                byte[] data = File.ReadAllBytes(sourceFilePathTextBox.Text);
                byte[] hash = alg.ComputeHash(data);

                using (RSA rsa = RSA.Create())
                {
                    rsa.FromXmlString(File.ReadAllText("output"));

                    RSAPKCS1SignatureDeformatter rsaDeformatter = new RSAPKCS1SignatureDeformatter(rsa);
                    rsaDeformatter.SetHashAlgorithm(nameof(SHA256));

                    if (rsaDeformatter.VerifySignature(hash, signedHash))
                    {
                        MessageBox.Show("Файл підписано. Підпис вірний.");
                    }
                    else
                    {
                        MessageBox.Show("Увага! Файл НЕ пройшов перевірку!!!");
                    }
                }
            }
            else
                MessageBox.Show("Виберіть файл для дешифрування та/або файл підпису");
        }

        private void sourceFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                sourceFilePathTextBox.Text = ofd.FileName;
            }
        }

        private void signFileButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                signFilePathTextBox.Text = ofd.FileName;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox_p_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
