using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public static class Problem7
    {
        // By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
        // What is the 10 001st prime number?

        static void Main(string[] args)
        {
            int count = 0;
            int number = 2;

            while (count < 10001)
            {
                if (IsPrime(number))
                {
                    count++;
                }
                number++;
            }

            Console.WriteLine("The 10,001st prime number is: " + (number - 1));
        }

        static bool IsPrime(int number)
        {
            if (number < 2)
            {
                return false;
            }
            else if (number == 2)
            {
                return true;
            }

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}