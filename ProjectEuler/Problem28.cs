using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public static class Problem28
    {
        // What is the sum of the numbers on the diagonals in a 1001 by 1001 spiral formed in the same way?

        public static void Run()
        {
            const int size = 1001; // size of the spiral
            int sum = 1; // initialize sum to 1 (the center of the spiral)
            int currentNumber = 1; // initialize current number to 1
            int sideLength = 2; // initialize side length to 2 (first layer of spiral)

            while (sideLength <= size)
            {
                // add each of the four corners of the current layer to the sum
                for (int i = 0; i < 4; i++)
                {
                    currentNumber += sideLength;
                    sum += currentNumber;
                }

                // increment the side length for the next layer
                sideLength += 2;
            }

            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}