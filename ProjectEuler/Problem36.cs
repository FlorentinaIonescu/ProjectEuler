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
    public static class Problem36
    {
        // The decimal number, 585 = 10010010012 (binary), is palindromic in both bases.
        // Find the sum of all numbers, less than one million, which are palindromic in base 10 and base 2.
        // (Please note that the palindromic number, in either base, may not include leading zeros.)

        // method takes a string and returns true if the string is a palindrome 
        static bool IsPalindrome(string str)
        {
            int length = str.Length;
            for (int i = 0; i < length / 2; i++)
            {
                if (str[i] != str[length - i - 1])
                {
                    return false;
                }
            }
            return true;
        }

        // method takes an integer and returns true if its binary representation is a palindrome
        static bool IsBinaryPalindrome(int n)
        {
            string binaryStr = Convert.ToString(n, 2);
            return IsPalindrome(binaryStr);
        }

        // It iterates over all numbers less than 1,000,000 and checks if each number is a palindrome in base 10 and in binary.
        // If so, it adds the number to a running total.
        public static void Run()
        {
            int sum = 0;
            for (int i = 1; i < 1000000; i++)
            {
                if (IsPalindrome(i.ToString()) && IsBinaryPalindrome(i))
                {
                    sum += i;
                }
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}