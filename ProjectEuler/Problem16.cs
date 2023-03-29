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
    public static class Problem16
    {
        // What is the sum of the digits of the number 2(1000)?

        // program uses the BigInteger class to compute 2^1000, and then iteratively sums up the digits of the resulting number
        public static void Run()
        {
            BigInteger power = BigInteger.Pow(2, 1000);
            int sum = 0;
            while (power > 0)
            {
                sum += (int)(power % 10);
                power /= 10;
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}