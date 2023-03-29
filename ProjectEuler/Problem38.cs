using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public static class Problem38
    {
        // What is the largest 1 to 9 pandigital 9-digit number that can be formed as the concatenated product of an integer with (1,2, ... , n) where n > 1?

        // brute force approach
        public static void Run()
        {
            int largestPandigital = 0;
            // checks each integer i from 1 to 9999 and generates concatenated products until the length of the product exceeds 9 digits
            for (int i = 1; i < 10000; i++)
            {
                string concatenatedProduct = "";
                int n = 1;
                while (concatenatedProduct.Length < 9)
                {
                    concatenatedProduct += (i * n).ToString();
                    n++;
                }
                // checks if the product is a 9-digit pandigital number and updates the largest pandigital number found so far if necessary
                if (concatenatedProduct.Length == 9 && IsPandigital(concatenatedProduct))
                {
                    int pandigital = int.Parse(concatenatedProduct);
                    if (pandigital > largestPandigital)
                    {
                        largestPandigital = pandigital;
                    }
                }
            }
            Console.WriteLine(largestPandigital);
            Console.ReadLine();
        }

        // checks if a given string contains all the digits from 1 to 9 exactly once, and returns true if it is pandigital and false otherwise
        static bool IsPandigital(string s)
        {
            char[] digits = s.ToCharArray();
            Array.Sort(digits);
            string sorted = new string(digits);
            return sorted == "123456789";
        }
    }
}