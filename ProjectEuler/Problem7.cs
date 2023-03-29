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

        public static void Run()
        {
            int count = 0;
            int number = 2;

            // Loop continues until the count reaches 10001, checking if the current number is prime using the IsPrime method.
            // If the number is prime, it increments the count variable. Regardless of whether the number is prime, it increments the number variable.

            while (count < 10001)
            {
                if (IsPrime(number))
                {
                    count++;
                }
                number++;
            }

            // Outputting the value of the number variable minus 1 (since the loop increments the number variable after checking whether it's prime, so the final value of the number variable will be one greater than the 10001st prime number).

            Console.WriteLine("The 10,001st prime number is: " + (number - 1));
            Console.ReadLine();
        }

        static bool IsPrime(int number)
        {
            // It first checks if the number is less than 2, and if so, it returns false (since 2 is the smallest prime number).
            // If the number is exactly 2, it returns true (since 2 is prime). 

            if (number < 2)
            {
                return false;
            }
            else if (number == 2)
            {
                return true;
            }

            // It checks if the number is divisible by any integers between 2 and the square root of the number (inclusive).
            // If it finds any such divisors, it returns false; otherwise, it returns true.

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