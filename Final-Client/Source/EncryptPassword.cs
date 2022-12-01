using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Quiz_Project
{
    internal class EncryptPassword
    {
        // Constructor
        private string text;
        public EncryptPassword()
        {
            text = null;
        }
        public EncryptPassword(string text)
        {
            this.text = text;
        }

        // Method
        public string EnCryptText()
        {
            byte[] encodedPassword = new UTF8Encoding().GetBytes(text);
            byte[] hash = ((HashAlgorithm)CryptoConfig.CreateFromName("MD5")).ComputeHash(encodedPassword);
            return text =  BitConverter.ToString(hash).Replace("-", string.Empty).ToLower();
        }
    }
}
