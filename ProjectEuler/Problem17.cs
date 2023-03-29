using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public static class Problem17
    {
        // If the numbers 1 to 5 are written out in words: one, two, three, four, five, then there are 3 + 3 + 5 + 4 + 4 = 19 letters used in total.
        // If all the numbers from 1 to 1000 (one thousand) inclusive were written out in words, how many letters would be used?
        // NOTE: Do not count spaces or hyphens.For example, 342 (three hundred and forty-two) contains 23 letters and 115 (one hundred and fifteen) contains 20 letters.The use of "and" when writing out numbers is in compliance with British usage.

        public static void Run()
        {
            int sum = 0;
            // loops through all numbers from 1 to 1000, gets their word representation, and adds the length of the word to the sum variable
            for (int i = 1; i <= 1000; i++)
            {
                sum += GetNumberWord(i).Length;
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }

        public static string GetNumberWord(int number) // returns the word representation of a given number
        {
            // only returns the alphabetic characters for each number word
            if (number == 1000)
            {
                return "onethousand";
            }
            if (number >= 100)
            {
                return GetOnesDigit(number / 100) + "hundred" + GetTensAndOnesDigits(number % 100);
            }
            return GetTensAndOnesDigits(number);
        }

        public static string GetTensAndOnesDigits(int number)
        {
            if (number < 10)
            {
                return GetOnesDigit(number);
            }
            if (number < 20)
            {
                return GetTeensDigit(number);
            }
            return GetTensDigit(number / 10) + GetOnesDigit(number % 10);
        }

        public static string GetOnesDigit(int number)
        {
            switch (number)
            {
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
                default: return "";
            }
        }

        public static string GetTensDigit(int number)
        {
            switch (number)
            {
                case 2: return "twenty";
                case 3: return "thirty";
                case 4: return "forty";
                case 5: return "fifty";
                case 6: return "sixty";
                case 7: return "seventy";
                case 8: return "eighty";
                case 9: return "ninety";
                default: return "";
            }
        }

        public static string GetTeensDigit(int number)
        {
            switch (number)
            {
                case 10: return "ten";
                case 11: return "eleven";
                case 12: return "twelve";
                case 13: return "thirteen";
                case 14: return "fourteen";
                case 15: return "fifteen";
                case 16: return "sixteen";
                case 17: return "seventeen";
                case 18: return "eighteen";
                case 19: return "nineteen";
                default: return "";
            }
        }
    }
}