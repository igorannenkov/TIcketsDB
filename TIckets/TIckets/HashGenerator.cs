using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace TIckets
{
    internal class HashGenerator
    {
        public static string GetMD5(string input)
        {
            using (System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create())
            {
                byte[] inputBytes = Encoding.Unicode.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);
                StringBuilder result = new StringBuilder();

                for (int i = 0; i < hashBytes.Length; i++)
                {
                    result.Append(hashBytes[i].ToString("X2"));
                }
                return result.ToString();
            }
        }
    }
}
