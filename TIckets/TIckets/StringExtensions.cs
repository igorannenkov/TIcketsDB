using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TIckets.Users
{
    public static class StringExtensions
    {
        public static bool IsValid(this string input)
        {
            string template = "!@#$%^&*()_+=~`//|,<>?:;\\";
            for(int i = 0; i< input.Length; i++) 
            {
                for (int j = 0; j < template.Length; j++)
                {
                    if (input[i] == template[j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }
    }
}