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

        static void Main()
        {
            BigInteger power = BigInteger.Pow(2, 1000);
            int sum = 0;
            while (power > 0)
            {
                sum += (int)(power % 10);
                power /= 10;
            }
            Console.WriteLine(sum);
        }
    }
}