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

        static void Main(string[] args)
        {
            for (int a = 1; a < 1000; a++)
            {
                for (int b = a + 1; b < 1000; b++)
                {
                    int c = 1000 - a - b;
                    if (a * a + b * b == c * c)
                    {
                        Console.WriteLine(a * b * c);
                        return;
                    }
                }
            }
            Console.WriteLine("No answer found.");
        }
    }
}