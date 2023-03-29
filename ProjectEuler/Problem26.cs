using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public static class Problem26
    {
        // Find the value of d < 1000 for which 1/d contains the longest recurring cycle in its decimal fraction part.

        public static void Run()
        {
            int maxLength = 0;
            int maxNumber = 0;

            for (int i = 2; i < 1000; i++)
            {
                int[] remainders = new int[i]; //array to keep track of the remainders encountered during long division
                int value = 1;
                int position = 0;

                //stops the calculation once a remainder is repeated
                while (remainders[value] == 0 && value != 0)
                {
                    remainders[value] = position;
                    value *= 10;
                    value %= i;
                    position++;
                }

                //length of the cycle is then computed by subtracting the position of the first occurrence of the repeated remainder from the current position
                if (position - remainders[value] > maxLength)
                {
                    maxLength = position - remainders[value];
                    maxNumber = i;
                }
            }

            Console.WriteLine("The value of d < 1000 for which 1/d contains the longest recurring cycle is " + maxNumber + ".");
            Console.ReadLine();
        }
    }
}