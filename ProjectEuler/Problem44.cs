using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public static class Problem44
    {
        // Find the pair of pentagonal numbers, Pj and Pk, for which their sum and difference are pentagonal and D = |Pk − Pj| is minimised; what is the value of D?

        // this program assumes that there exists a solution with a difference less than int.MaxValue as guaranteed by the problem statement
        public static void Run()
        {
            int j = 1, k = 1;
            int minDiff = int.MaxValue;

            while (true)
            {
                int pj = Pentagonal(j);
                int pk = Pentagonal(k);

                // checks if their sum and difference are both pentagonal and updates the minimum difference accordingly
                int sum = pj + pk;
                int diff = pk - pj;

                if (diff >= minDiff)
                {
                    Console.WriteLine(minDiff);
                    Console.ReadLine();
                    break;
                }

                if (IsPentagonal(sum) && IsPentagonal(diff))
                {
                    minDiff = diff;
                    Console.WriteLine(minDiff);
                    Console.ReadLine();
                }

                if (j == k)
                {
                    k++;
                }
                else if (j < k)
                {
                    j++;
                }
                else
                {
                    k++;
                }
            }
        }

        // calculates the nth pentagonal number using the formula n * (3 * n - 1) / 2
        static int Pentagonal(int n)
        {
            return n * (3 * n - 1) / 2;
        }

        // checks if a given number is pentagonal
        static bool IsPentagonal(int n)
        {
            int x = (int)Math.Sqrt(24 * n + 1);
            return x * x == 24 * n + 1 && (x + 1) % 6 == 0;
        }
    }
}