using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public static class Problem1
    {
        public static void Run()

        {
            int sum = 0;
            for (int i = 1; i < 1000; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine("The sum of all the multiples of 3 or 5 below 1000 is: " + sum);


            //int finalSum = 0;

            //int a = 993 + 995 + 996 + 999;

            //int b = 330 * (990 + 3) / 2;

            //int c = 198 * (990 + 5) / 2;

            //int d = 66 * (990 + 15) / 2;

            //finalSum = a + b + c - d;

            //Console.WriteLine(finalSum);

            //Console.Read();

        }
    }
}