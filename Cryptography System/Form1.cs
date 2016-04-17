using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cryptography_System
{
    public partial class Form1 : Form
    {

        private bool processing = false;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tripledes_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void openInputFile_FileOk(object sender, CancelEventArgs e)
        {
            
        }

        private void openInput_Click(object sender, EventArgs e)
        {
            OpenFileDialog openInputFile = new OpenFileDialog();
            DialogResult result = openInputFile.ShowDialog();
            
            if(result == DialogResult.OK)
            {
                inputFile.Text = openInputFile.FileName;
            }
        }

        private void openOutput_Click(object sender, EventArgs e)
        {
            OpenFileDialog openOutputFile = new OpenFileDialog();
            DialogResult result = openOutputFile.ShowDialog();

            if(result == DialogResult.OK)
            {
                outputFile.Text = openOutputFile.FileName;
            }
        }

        private void openInputFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openInput_Click(sender, e);
        }

        private void openOutputFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openOutput_Click(sender, e);
        }

        public void updateProgress(int progress)
        {
            bool uiAccess = progressBar1.InvokeRequired;

            if(uiAccess)
            {
                progressBar1.Invoke(new Action(() => { progressBar1.Value = progress; }));
            }
            progressBar1.Value = progress;
        }

        public void doneProcessing()
        {
            processing = false;
        }

        private void encrypt_Click(object sender, EventArgs e)
        {
            if (!processing)
            {
                processing = true;
                //TODO:  handle empty fields
                String algorithm = "";
                var checkedButton = encryptionGroup.Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked);
                algorithm = checkedButton.Name;
                String inFile = inputFile.Text;
                String outFile = outputFile.Text;
                String pword = password.Text;
                Thread encryption = new Thread(delegate () {
                    EncDec.Encrypt(inFile, outFile, pword, algorithm, this);
                });
                encryption.Start();
            }
        }

        private void decrypt_Click(object sender, EventArgs e)
        {
            if (!processing)
            {
                //TODO:  handle empty fields
                //crashes if password is wrong
                String algorithm = "";
                var checkedButton = encryptionGroup.Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked);
                algorithm = checkedButton.Name;
                String inFile = inputFile.Text;
                String outFile = outputFile.Text;
                String pword = password.Text;
                Thread decryption = new Thread(delegate () {
                    EncDec.Decrypt(inFile, outFile, pword, algorithm, this);
                });
                decryption.Start();
            }
        }

        private void digest_Click(object sender, EventArgs e)
        {
            if (!processing)
            {
                processing = true;
                //TODO:  handle empty fields
                String algorithm = "";
                var checkedButton = hashGroup.Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked);
                algorithm = checkedButton.Name;
                String inFile = inputFile.Text;
                String outFile = outputFile.Text;
                Thread digestion = new Thread(delegate () {
                    EncDec.Digest(inFile, outFile, algorithm, this);
                });
                digestion.Start();
            }
        }

        private void md5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            String message = "Crptography System\n\n";
            message += "CS 570 Spring 2016\n";
            message += "Kholby Lawson & Garland Kinslow\n\n";
            message += "The system should provide four symmetric encryption algorithm choices (DES, RC2, Rijndael, 3DES) and four message ";
            message += "digest(or Hash) algorithm choices (MD5, SHA1, SHA256, SHA512).The encryption algorithm choice is relevant only ";
            message += "during encryption and decryption which, in turn, can be invoked using any of the Encrypt and Decrypt buttons.";
            message += "Likewise, the choice of a message digest algorithm is pertinent only during the invocation of the file hashing process.The";
            message += " progress bar is used to indicate the status of the encryption / decryption / message digest process on a selected file. ";
            MessageBox.Show(message);
        }
    }
}
