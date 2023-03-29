using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public static class Problem39
    {
        // If p is the perimeter of a right angle triangle with integral length sides, {a,b,c}, there are exactly three solutions for p = 120:
        // {20,48,52}, {24,45,51}, {30,40,50}
        // For which value of p ≤ 1000, is the number of solutions maximised?

        // Note: This program assumes that a, b, and c are integers.
        // If non-integer side lengths are allowed, the program will need to be modified to use floating-point numbers.
        public static void Run()
        {
            int maxPerimeter = 0;
            int maxSolutions = 0;

            // program iterates through all possible perimeters (from 1 to 1000),
            // and for each perimeter, it checks all possible combinations of side lengths (a, b, c) that could form a right-angled triangle with that perimeter
            for (int p = 1; p <= 1000; p++)
            {
                int numSolutions = 0;

                for (int a = 1; a <= p / 2; a++)
                {
                    for (int b = a; b <= p / 2; b++)
                    {
                        int c = p - a - b;

                        if (c > 0 && a * a + b * b == c * c)
                        {
                            numSolutions++;
                        }
                    }
                }

                if (numSolutions > maxSolutions)
                {
                    maxSolutions = numSolutions;
                    maxPerimeter = p;
                }
            }

            Console.WriteLine("The maximum number of solutions is {0} for p = {1}", maxSolutions, maxPerimeter);
            Console.ReadLine();
        }
    }
}