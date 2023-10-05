using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SymmetricalEncryption
{
    internal class Encryptor
    {
        public string InputFile;
        public string OutputFile;

        public event EventHandler OnUpdate;

        public void Encrypt(string password)
        {
            // input
            byte[] plaintext = File.ReadAllBytes(InputFile);
            byte[] key = Encoding.ASCII.GetBytes(password);
            byte[] ciphertext = new byte[plaintext.Length];

            // do encoding
            for(int i = 0; i < plaintext.Length; i++)
            {
                byte plaintextByte = plaintext[i];
                byte keyByte = key[i % key.Length];
                byte ciphertextByte = (byte)(keyByte ^ plaintextByte);
                ciphertext[i] = ciphertextByte;
            }

            // output
            File.WriteAllBytes(OutputFile, ciphertext);
        }

        public Encryptor(string InputFile, string OutputFile)
        {
            this.InputFile = InputFile;
            this.OutputFile = OutputFile;
            
        }
    }
}
