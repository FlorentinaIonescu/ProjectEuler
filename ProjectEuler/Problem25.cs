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
    public static class Problem25
    {
        // What is the index of the first term in the Fibonacci sequence to contain 1000 digits?

        public static void Run()
        {
            int numDigits = 1000;
            int term = 2;

            BigInteger fib1 = 1;
            BigInteger fib2 = 1;

            // generating Fibonacci numbers until we find one with the desired number of digits
            while (fib2.ToString().Length < numDigits)
            {
                // swappnig values so that fib1 holds the previous Fibonacci number and fib2 holds the current Fibonacci number
                BigInteger temp = fib2;
                fib2 = fib1 + fib2;
                fib1 = temp;
                term++; //incrementing each tiem we generate a new Fibonacci number
            }

            Console.WriteLine(term);
            Console.ReadLine();
        }
    }
}