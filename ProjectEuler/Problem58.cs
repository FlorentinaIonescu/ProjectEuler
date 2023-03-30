using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public static class Problem58
    {
        // If one complete new layer is wrapped around the spiral above, a square spiral with side length 9 will be formed.
        // If this process is continued, what is the side length of the square spiral for which the ratio of primes along both diagonals first falls below 10%?

        public static void Run()
        {
            int sideLength = 3;
            int primes = 3;
            int totalNumbers = 5;
            while ((double)primes / totalNumbers >= 0.10)
            {
                sideLength += 2;
                int bottomRight = sideLength * sideLength;
                for (int i = 0; i < 3; i++)
                {
                    int corner = bottomRight - i * (sideLength - 1);
                    if (IsPrime(corner))
                    {
                        primes++;
                    }
                }
                totalNumbers += 4;
            }
            Console.WriteLine(sideLength);
            Console.ReadLine();
        }

        static bool IsPrime(int n)
        {
            if (n < 2)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}