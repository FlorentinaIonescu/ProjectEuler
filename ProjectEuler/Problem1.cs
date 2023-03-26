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

            int finalSum = 0;

            int a = 993 + 995 + 996 + 999;

            int b = 330 * (990 + 3) / 2;

            int c = 198 * (990 + 5) / 2;

            int d = 66 * (990 + 15) / 2;

            finalSum = a + b + c - d;

            Console.WriteLine(finalSum);

            Console.Read();

        }
    }
}