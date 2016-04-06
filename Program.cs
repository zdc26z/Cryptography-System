using System;
using System.IO; 
using System.Text;
using System.Security.Cryptography; 
using Gtk;

namespace CryptographySystem
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			Application.Init ();
			MainWindow win = new MainWindow ();
			win.Show ();
			Application.Run ();
		}
	}

	public class EncDec 
	{
		// Encrypt a file into another file using a password 
		public static void Encrypt(string fileIn, 
			string fileOut, string Password, string Algorithm, MainWindow win) 
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
			switch (Algorithm) {
			case "DES":
				alg = DES.Create ();
				alg.Key = pdb.GetBytes(8); 
				alg.IV = pdb.GetBytes(8); 
				break;
			case "RC2":
				alg = RC2.Create ();
				alg.Key = pdb.GetBytes(16); 
				alg.IV = pdb.GetBytes(8); 
				break;
			case "Rijndael":
				alg = Rijndael.Create ();
				alg.Key = pdb.GetBytes(32); 
				alg.IV = pdb.GetBytes(16); 
				break;
			default:
				alg = TripleDES.Create ();
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
			win.updateProgress (0);
			do { 
				// read a chunk of data from the input file 
				bytesRead = fsIn.Read(buffer, 0, bufferLen); 
				totalBytesRead += bytesRead;
				double current = (double) totalBytesRead / (double) totalBytes;
				win.updateProgress(current);
				// encrypt it 
				cs.Write(buffer, 0, bytesRead); 
			} while(bytesRead != 0); 

			// close everything 

			// this will also close the unrelying fsOut stream
			cs.Close(); 
			fsIn.Close();     
			win.doneProcessing ();
		} 

		// Decrypt a file into another file using a password 
		public static void Decrypt(string fileIn, 
			string fileOut, string Password, string Algorithm, MainWindow win) 
		{ 

			// First we are going to open the file streams 
			FileStream fsIn = new FileStream(fileIn,
				FileMode.Open, FileAccess.Read); 
			FileStream fsOut = new FileStream(fileOut,
				FileMode.OpenOrCreate, FileAccess.Write); 

			// Then we are going to derive a Key and an IV from
			// the Password and create an algorithm 
			PasswordDeriveBytes pdb = new PasswordDeriveBytes(Password, 
				new byte[] {0x49, 0x76, 0x61, 0x6e, 0x20, 0x4d, 
					0x65, 0x64, 0x76, 0x65, 0x64, 0x65, 0x76}); 
			//Rijndael alg = Rijndael.Create(); 
			SymmetricAlgorithm alg = null;
			switch (Algorithm) {
			case "DES":
				alg = DES.Create ();
				alg.Key = pdb.GetBytes(8); 
				alg.IV = pdb.GetBytes(8); 
				break;
			case "RC2":
				alg = RC2.Create ();
				alg.Key = pdb.GetBytes(16); 
				alg.IV = pdb.GetBytes(8); 
				break;
			case "Rijndael":
				alg = Rijndael.Create ();
				alg.Key = pdb.GetBytes(32); 
				alg.IV = pdb.GetBytes(16); 
				break;
			default:
				alg = TripleDES.Create ();
				alg.Key = pdb.GetBytes(16); 
				alg.IV = pdb.GetBytes(8); 
				break;
			}


			// Now create a crypto stream through which we are going
			// to be pumping data. 
			// Our fileOut is going to be receiving the Decrypted bytes. 
			CryptoStream cs = new CryptoStream(fsOut, 
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
			win.updateProgress (0);
			do { 
				// read a chunk of data from the input file 
				bytesRead = fsIn.Read(buffer, 0, bufferLen); 
				totalBytesRead += bytesRead;
				double current = (double) totalBytesRead / (double) totalBytes;
				win.updateProgress(current);
				// Decrypt it 
				cs.Write(buffer, 0, bytesRead); 

			} while(bytesRead != 0); 

			// close everything 
			cs.Close(); // this will also close the unrelying fsOut stream 
			fsIn.Close();    
			win.doneProcessing ();
		}

		public static void Digest(string fileIn, 
			string fileOut, string Algorithm, MainWindow win)
		{ 

			// First we are going to open the file streams 
			FileStream fsIn = new FileStream(fileIn,
				FileMode.Open, FileAccess.Read); 
			FileStream fsOut = new FileStream(fileOut,
				FileMode.OpenOrCreate, FileAccess.Write);
			StreamWriter outWriter = new StreamWriter (fsOut);

			//then pick the algorithm
			HashAlgorithm hash = null;
			switch (Algorithm) {
			case "md5":
				hash = MD5.Create ();
				break;
			case "sha1":
				hash = SHA1.Create ();
				break;
			case "sha256":
				hash = SHA256.Create ();
				break;
			default:
				hash = SHA512.Create ();
				break;
			}

			int bufferLen = 4096; 
			byte[] buffer = new byte[bufferLen]; 
			int bytesRead; 
			int totalBytesRead = 0;
			long totalBytes = fsIn.Length;
			win.updateProgress (0);

			do { 
//				StringBuilder sBuilder = new StringBuilder ();
//				// read a chunk of data from the input file 
				bytesRead = fsIn.Read(buffer, 0, bufferLen); 
				totalBytesRead += bytesRead;
				double current = (double) totalBytesRead / (double) totalBytes;
				win.updateProgress(current);
				hash.TransformBlock(buffer, 0, bytesRead, buffer, 0);
			} while(bytesRead != 0); 

			hash.TransformFinalBlock (new byte[0], 0, 0);
			buffer = hash.Hash;

			String hashString = BitConverter.ToString (buffer);
			outWriter.WriteLine (hashString);
			// close everything 
			outWriter.Close();
			fsOut.Close();
			fsIn.Close();    
			win.doneProcessing ();
		}
	}
}