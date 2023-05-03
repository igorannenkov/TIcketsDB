using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TIckets.Users
{
    public static class StringExtensions
    {
        public static bool IsValidInput(this string input)
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

        public static string GetPasswordStrength(this string input, out Color color )
        {
            if (input.Length > 8 &&
                input.Any(p => Char.IsLetterOrDigit(p) &&
                input.Any(q => !Char.IsLetterOrDigit(q) &&
                input.Any(r => Char.IsLower(r) &&
                input.Any(s => Char.IsUpper(s))))))
            {
                color = Color.Green;
                return "Высокая";
            }

            if (input.Length < 8 || input.All(p => char.IsDigit(p)))
            {
                color = Color.Red;
                return "Низкая";
            }
            else if (input.Length > 8 && input.Any(p => Char.IsLetterOrDigit(p)))
            {
                color = Color.Orange;
                return "Средняя";
            }
            
            color = Color.Red;
            return "Низкая";
        }
    }
}