using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public static class Problem21
    {
        // Evaluate the sum of all the amicable numbers under 10000.

        public static void Run()
        {
            int limit = 10000;
            int[] d = new int[limit]; // array used to store the sum of divisors for each number up to the limit

            // It loops through each number up to limit, calculates the sum of its divisors and stores it in the d array
            for (int i = 1; i < limit; i++)
            {
                for (int j = i * 2; j < limit; j += i)
                {
                    d[j] += i;
                }
            }

            // it loops through each number up to limit again and checks if it is amicable by verifying if the sum of divisors of its sum of divisors equals the number itself,
            // and adds it to the running total sum if it is. 
            int sum = 0;
            for (int i = 1; i < limit; i++)
            {
                int j = d[i];
                if (j != i && j < limit && d[j] == i)
                {
                    sum += i;
                }
            }

            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}