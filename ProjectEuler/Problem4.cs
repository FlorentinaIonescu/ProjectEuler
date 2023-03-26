using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public static class Problem4
    {
        // A palindromic number reads the same both ways.The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
        // Find the largest palindrome made from the product of two 3-digit numbers.


        public static void Run()
        {
            int maxPalindrome = 0; // initialize variable to store maximum palindrome found
            int maxI = 0; // initialize variable to store the first factor of the maximum palindrome
            int maxJ = 0; // initialize variable to store the second factor of the maximum palindrome

            // loop through all 3-digit numbers in descending order
            for (int i = 999; i >= 100; i--)
            {
                for (int j = i; j >= 100; j--)
                {
                    int product = i * j; // calculate the product of the two factors

                    // check if the product is a palindrome and greater than the current maximum palindrome found
                    if (IsPalindrome(product) && product > maxPalindrome)
                    {
                        maxPalindrome = product; // update the maximum palindrome found
                        maxI = i; // update the first factor of the maximum palindrome
                        maxJ = j; // update the second factor of the maximum palindrome
                    }
                }
            }

            Console.WriteLine($"The largest palindrome made from the product of two 3-digit numbers is {maxPalindrome}");
            Console.WriteLine($"It is the product of {maxI} and {maxJ}");
            Console.ReadLine();
        }

        static bool IsPalindrome(int number)
        {
            string s = number.ToString(); // convert the number to a string
            int len = s.Length;

            // loop through half the string and compare the first and last character, second and second to last, and so on
            for (int i = 0; i < len / 2; i++)
            {
                if (s[i] != s[len - i - 1])
                {
                    return false; // if any pair of characters don't match, the number is not a palindrome
                }
            }
            return true; // if all pairs of characters match, the number is a palindrome
        }

    }
}