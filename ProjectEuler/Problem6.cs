using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public static class Problem6
    {
        // ... Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.

        public static void Main()
        {
            int sumOfSquares = 0;
            int squareOfSum = 0;

            for (int i = 1; i <= 100; i++)
            {
                sumOfSquares += i * i;
                squareOfSum += i;
            }

            squareOfSum *= squareOfSum;

            int result = squareOfSum - sumOfSquares;

            Console.WriteLine("The difference between the sum of the squares of the first 100 natural numbers and the square of the sum is: " + result);
        }
    }
}