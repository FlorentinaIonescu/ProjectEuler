using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public static class Problem5
    {
        // 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
        // What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?


        public static void Run()
        {
            int limit = 20;
            int smallestMultiple = GetSmallestMultiple(limit);
            Console.WriteLine("The smallest positive number that is evenly divisible by all of the numbers from 1 to {0} is {1}.", limit, smallestMultiple);
            Console.ReadLine();
        }

        static int GetSmallestMultiple(int limit)
        {
            int smallestMultiple = limit;
            bool found = false;

            while (!found)
            {
                for (int i = 1; i <= limit; i++)
                {
                    if (smallestMultiple % i != 0)
                    {
                        smallestMultiple++;
                        break;
                    }
                    else if (i == limit)
                    {
                        found = true;
                    }
                }
            }

            return smallestMultiple;
        }

    }
}