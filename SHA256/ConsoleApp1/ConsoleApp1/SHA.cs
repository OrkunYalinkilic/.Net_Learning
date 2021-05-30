using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class SHA
    {
        public static string SHA256Sifrele(string deger)
        {
            SHA256 sha256 = SHA256Managed.Create();
            byte[] degerbyte = Encoding.UTF8.GetBytes(deger);
            byte[] sha256Byte = sha256.ComputeHash(degerbyte);
            return HashToByte(sha256Byte);
        }

        public static string SHA512Sifrele(string deger)
        {
            return string.Empty;
        }

        private static string HashToByte(byte[] hash)
        {
            StringBuilder sonuc = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sonuc.Append(hash[i].ToString("X2"));
            }
            return sonuc.ToString();
        }
    }
}
