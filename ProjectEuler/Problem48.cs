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
    public static class Problem48
    {
        // The series, 11 + 22 + 33 + ... + 1010 = 10405071317.
        // Find the last ten digits of the series, 11 + 22 + 33 + ... + 10001000.


        public static void Run()
        {
            BigInteger sum = 0;
            for (int i = 1; i <= 1000; i++)
            {
                BigInteger power = BigInteger.Pow(i, i); // calculate the power of the number to itself 
                sum += power % 10000000000; // add the last ten digits of the power to the sum using the modulo operator %
            }
            Console.WriteLine(sum % 10000000000); // output the last ten digits of the sum 
            Console.ReadLine();
        }
    }
}