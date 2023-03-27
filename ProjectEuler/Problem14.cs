using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public static class Problem14
    {
        // ... Which starting number, under one million, produces the longest chain?

        static void Main(string[] args)
        {
            long maxLength = 0;
            long maxStartingNumber = 0;

            for (long i = 1; i < 1000000; i++)
            {
                long n = i;
                long length = 1;

                while (n != 1)
                {
                    if (n % 2 == 0)
                    {
                        n = n / 2;
                    }
                    else
                    {
                        n = 3 * n + 1;
                    }
                    length++;
                }

                if (length > maxLength)
                {
                    maxLength = length;
                    maxStartingNumber = i;
                }
            }

            Console.WriteLine("The starting number {0} produces a sequence of {1} terms.", maxStartingNumber, maxLength);
            Console.ReadKey();
        }
    }
}