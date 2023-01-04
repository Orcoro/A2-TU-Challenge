using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge
{
    public class MyStringImplementation
    {
        public static string BazardString(string input)
        {
            string result = "";
            
            for (int i = 0; i != input.Length + 1; i += 2) {
                if (i == input.Length)
                    i = 1;
                result += input[i];
            }
            return result;
        }

        public static bool IsNullEmptyOrWhiteSpace(string input)
        {
            if (input == null || input == "")
                return true;
            for (int i = 0; i < input.Length; i++)
                if (input[i] != ' ')
                    return false;
            return true;
        }

        public static string MixString(string a, string b)
        {
            string result = "";

            if (IsNullEmptyOrWhiteSpace(a) || IsNullEmptyOrWhiteSpace(b))
                throw new ArgumentException();
            for (int i = 0; i < a.Length || i < b.Length; i++) {
                if (i < a.Length)
                    result += a[i];
                if (i < b.Length)
                    result += b[i];
            }
            return result;
        }

        public static string Reverse(string a)
        {
            string result = "";
            for (int i = a.Length - 1; i >= 0; i--)
                result += a[i];
            return result;
        }

        public static string ToCesarCode(string input, int offset)
        {
            string result = "";

            for (int i = 0; i < input.Length; i++) {
                if (input[i] >= 'a' && input[i] <= 'z')
                    result += (char)('a' + (input[i] - 'a' + offset) % 26);
                else if (input[i] >= 'A' && input[i] <= 'Z')
                    result += (char)('A' + (input[i] - 'A' + offset) % 26);
                else
                    result += input[i];
            }
            return result;
        }

        public static string ToLowerCase(string a)
        {
            string result = "";
            
            for (int i = 0; i < a.Length; i++) {
                if (a[i] >= 'A' && a[i] <= 'Z' || a[i] >= 'À' && a[i] <= 'Þ')
                    result += (char)(a[i] + 32);
                else
                    result += a[i];
            }
            return result;
        }

        public static string UnBazardString(string input)
        {
            string a = "";
            string b = "";

            for (int i = 0; i < input.Length / 2; i++)
                a += input[i];
            for (int i = input.Length / 2; i < input.Length; i++)
                b += input[i];

            return MixString(a, b);
        }

        public static string Voyelles(string a)
        {
            string result = "";

            for (int i = 0; i < a.Length; i++)
                if (a[i] == 'a' || a[i] == 'e' || a[i] == 'i' || a[i] == 'o' || a[i] == 'u' || a[i] == 'y' || a[i] == 'A' || a[i] == 'E' || a[i] == 'I' || a[i] == 'O' || a[i] == 'U' || a[i] == 'Y') 
                    if (!result.Contains(a[i]))
                        result += a[i];
            result = ToLowerCase(result);
            return result;
        }
    }
}
