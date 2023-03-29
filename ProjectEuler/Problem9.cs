using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public static class Problem9
    {
        // There exists exactly one Pythagorean triplet for which a + b + c = 1000. Find the product abc.

        // The program uses a nested loop to iterate through all possible values of a and b from 1 to 999,
        // and then calculates the value of c using the formula c = 1000 - a - b.
        // It then checks if a^2 + b^2 = c^2, and if it does, it outputs the product a * b * c.
        // If no answer is found, it outputs the message "No answer found."

        public static void Run()
        {
            for (int a = 1; a < 1000; a++)
            {
                for (int b = a + 1; b < 1000; b++)
                {
                    int c = 1000 - a - b;
                    if (a * a + b * b == c * c)
                    {
                        Console.WriteLine(a * b * c);
                        Console.ReadLine();
                        return;
                    }
                }
            }
            Console.WriteLine("No answer found.");
            Console.ReadLine();
        }
    }
}