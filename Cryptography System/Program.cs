using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cryptography_System
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    public class EncDec
    {
        // Encrypt a file into another file using a password 
        public static void Encrypt(string fileIn,
            string fileOut, string Password, string Algorithm, Form1 win)
        {

            try
            {
                // First we are going to open the file streams 
                FileStream fsIn = new FileStream(fileIn,
                    FileMode.Open, FileAccess.Read);
                FileStream fsOut = new FileStream(fileOut,
                    FileMode.Create, FileAccess.Write);

                // Then we are going to derive a Key and an IV from the
                // Password and create an algorithm 
                PasswordDeriveBytes pdb = new PasswordDeriveBytes(Password,
                    new byte[] {0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d,
                        0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76});

                //Rijndael alg = Rijndael.Create(); 
                SymmetricAlgorithm alg = null;
                switch (Algorithm)
                {
                    case "des":
                        alg = DES.Create();
                        alg.Key = pdb.GetBytes(8);
                        alg.IV = pdb.GetBytes(8);
                        break;
                    case "rc2":
                        alg = RC2.Create();
                        alg.Key = pdb.GetBytes(16);
                        alg.IV = pdb.GetBytes(8);
                        break;
                    case "rijndael":
                        alg = Rijndael.Create();
                        alg.Key = pdb.GetBytes(32);
                        alg.IV = pdb.GetBytes(16);
                        break;
                    default:
                        alg = TripleDES.Create();
                        alg.Key = pdb.GetBytes(16);
                        alg.IV = pdb.GetBytes(8);
                        break;
                }

                // Now create a crypto stream through which we are going
                // to be pumping data. 
                // Our fileOut is going to be receiving the encrypted bytes. 
                CryptoStream cs = new CryptoStream(fsOut,
                    alg.CreateEncryptor(), CryptoStreamMode.Write);

                // Now will will initialize a buffer and will be processing
                // the input file in chunks. 
                // This is done to avoid reading the whole file (which can
                // be huge) into memory. 
                int bufferLen = 4096;
                byte[] buffer = new byte[bufferLen];
                int bytesRead;
                int totalBytesRead = 0;
                long totalBytes = fsIn.Length;
                win.updateProgress(0);
                do
                {
                    // read a chunk of data from the input file 
                    bytesRead = fsIn.Read(buffer, 0, bufferLen);
                    totalBytesRead += bytesRead;
                    int current = totalBytesRead / (int)totalBytes;
                    win.updateProgress(current * 100);
                    // encrypt it 
                    cs.Write(buffer, 0, bytesRead);
                } while (bytesRead != 0);

                // close everything 

                // this will also close the unrelying fsOut stream
                cs.Close();
                fsIn.Close();
            }
            catch(ArgumentException e)
            {
                MessageBox.Show("You must specify both an input an output file.");
            }
            catch(FileNotFoundException fnf)
            {
                MessageBox.Show("File not found!");
            }
            win.doneProcessing();
        }

        // Decrypt a file into another file using a password 
        public static void Decrypt(string fileIn,
            string fileOut, string Password, string Algorithm, Form1 win)
        {
            FileStream fsIn = null;
            FileStream fsOut = null;
            CryptoStream cs = null;
            try
            {
                // First we are going to open the file streams 
                fsIn = new FileStream(fileIn,
                    FileMode.Open, FileAccess.Read);
                fsOut = new FileStream(fileOut,
                    FileMode.OpenOrCreate, FileAccess.Write);

                // Then we are going to derive a Key and an IV from
                // the Password and create an algorithm 
                PasswordDeriveBytes pdb = new PasswordDeriveBytes(Password,
                    new byte[] {0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d,
                        0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76});
                //Rijndael alg = Rijndael.Create(); 
                SymmetricAlgorithm alg = null;
                switch (Algorithm)
                {
                    case "des":
                        alg = DES.Create();
                        alg.Key = pdb.GetBytes(8);
                        alg.IV = pdb.GetBytes(8);
                        break;
                    case "rc2":
                        alg = RC2.Create();
                        alg.Key = pdb.GetBytes(16);
                        alg.IV = pdb.GetBytes(8);
                        break;
                    case "rijndael":
                        alg = Rijndael.Create();
                        alg.Key = pdb.GetBytes(32);
                        alg.IV = pdb.GetBytes(16);
                        break;
                    default:
                        alg = TripleDES.Create();
                        alg.Key = pdb.GetBytes(16);
                        alg.IV = pdb.GetBytes(8);
                        break;
                }


                // Now create a crypto stream through which we are going
                // to be pumping data. 
                // Our fileOut is going to be receiving the Decrypted bytes. 
                cs = new CryptoStream(fsOut,
                    alg.CreateDecryptor(), CryptoStreamMode.Write);

                // Now will will initialize a buffer and will be 
                // processing the input file in chunks. 
                // This is done to avoid reading the whole file (which can be
                // huge) into memory. 
                int bufferLen = 4096;
                byte[] buffer = new byte[bufferLen];
                int bytesRead;
                int totalBytesRead = 0;
                long totalBytes = fsIn.Length;
                win.updateProgress(0);
                do
                {
                    // read a chunk of data from the input file 
                    bytesRead = fsIn.Read(buffer, 0, bufferLen);
                    totalBytesRead += bytesRead;
                    int current = totalBytesRead / (int)totalBytes;
                    win.updateProgress(current * 100);
                    // Decrypt it 
                    cs.Write(buffer, 0, bytesRead);

                } while (bytesRead != 0);

                // close everything 
                cs.Close(); // this will also close the unrelying fsOut stream 
                fsIn.Close();
            }
            catch (ArgumentException e)
            {
                MessageBox.Show("You must specify both an input an output file.");
            }
            catch (FileNotFoundException fnf)
            {
                MessageBox.Show("File not found!");
            }
            catch (CryptographicException ce)
            {
                MessageBox.Show("Error decyrpting file.  Is the password correct?");
                if(cs != null)
                {
                    cs.Close();
                }
                if(fsIn != null)
                {
                    fsIn.Close();
                }
            }
            win.doneProcessing();
        }

        public static void Digest(string fileIn,
            string fileOut, string Algorithm, Form1 win)
        {
            FileStream fsIn = null;
            FileStream fsOut = null;
            try
            {
                // First we are going to open the file streams 
                fsIn = new FileStream(fileIn,
                    FileMode.Open, FileAccess.Read);
                fsOut = new FileStream(fileOut,
                    FileMode.OpenOrCreate, FileAccess.Write);
                StreamWriter outWriter = new StreamWriter(fsOut);

                //then pick the algorithm
                HashAlgorithm hash = null;
                switch (Algorithm)
                {
                    case "md5":
                        hash = MD5.Create();
                        break;
                    case "sha1":
                        hash = SHA1.Create();
                        break;
                    case "sha256":
                        hash = SHA256.Create();
                        break;
                    default:
                        hash = SHA512.Create();
                        break;
                }

                int bufferLen = 4096;
                byte[] buffer = new byte[bufferLen];
                int bytesRead;
                int totalBytesRead = 0;
                long totalBytes = fsIn.Length;
                win.updateProgress(0);

                do
                {
                    //				StringBuilder sBuilder = new StringBuilder ();
                    //				// read a chunk of data from the input file 
                    bytesRead = fsIn.Read(buffer, 0, bufferLen);
                    totalBytesRead += bytesRead;
                    int current = totalBytesRead / (int)totalBytes;
                    win.updateProgress(current * 100);
                    hash.TransformBlock(buffer, 0, bytesRead, buffer, 0);
                } while (bytesRead != 0);

                hash.TransformFinalBlock(new byte[0], 0, 0);
                buffer = hash.Hash;

                String hashString = BitConverter.ToString(buffer);
                outWriter.WriteLine(hashString);
                // close everything 
                outWriter.Close();
                fsOut.Close();
                fsIn.Close();
            }
            catch (ArgumentException e)
            {
                MessageBox.Show("You must specify both an input an output file.");
            }
            catch (FileNotFoundException fnf)
            {
                MessageBox.Show("File not found!");
            }
            win.doneProcessing();
        }
    }
}
