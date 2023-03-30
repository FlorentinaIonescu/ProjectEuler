using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Numerics;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public static class Problem55
    {
        // How many Lychrel numbers are there below ten-thousand?

        static bool IsPalindrome(string s)
        {
            int n = s.Length;
            for (int i = 0; i < n / 2; i++)
            {
                if (s[i] != s[n - i - 1])
                {
                    return false;
                }
            }
            return true;
        }

        static string Reverse(string s)
        {
            char[] chars = s.ToCharArray();
            Array.Reverse(chars);
            return new string(chars);
        }

        static bool IsLychrelNumber(long n)
        {
            string s = n.ToString();
            for (int i = 0; i < 50; i++)
            {
                s = (BigInteger.Parse(s) + BigInteger.Parse(Reverse(s))).ToString();
                if (IsPalindrome(s))
                {
                    return false;
                }
            }
            return true;
        }

        public static void Run()
        {
            int count = 0;
            for (int i = 1; i < 10000; i++)
            {
                if (IsLychrelNumber(i))
                {
                    count++;
                }
            }
            Console.WriteLine(count);
            Console.ReadLine();
        }
    }
}