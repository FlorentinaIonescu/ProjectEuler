using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public static class Problem49
    {
        // The arithmetic sequence, 1487, 4817, 8147, in which each of the terms increases by 3330, is unusual in two ways: (i) each of the three terms are prime, and, (ii) each of the 4-digit numbers are permutations of one another.
        // There are no arithmetic sequences made up of three 1-, 2-, or 3-digit primes, exhibiting this property, but there is one other 4-digit increasing sequence.
        // What 12-digit number do you form by concatenating the three terms in this sequence?

        public static void Run()
        {
            List<int> primes = GeneratePrimes(10000);
            List<int> result = new List<int>();

            foreach (int prime1 in primes)
            {
                foreach (int prime2 in primes.Where(p => p > prime1))
                {
                    int prime3 = prime2 + (prime2 - prime1);

                    if (primes.Contains(prime3))
                    {
                        if (IsPermutation(prime1, prime2) && IsPermutation(prime2, prime3))
                        {
                            result.Add(prime1);
                            result.Add(prime2);
                            result.Add(prime3);
                        }
                    }
                }
            }

            Console.WriteLine(string.Join("", result.Select(n => n.ToString()).ToArray()));
        }

        static bool IsPermutation(int a, int b)
        {
            return new string(a.ToString().OrderBy(c => c).ToArray()) == new string(b.ToString().OrderBy(c => c).ToArray());
        }

        static List<int> GeneratePrimes(int max)
        {
            List<int> primes = new List<int>();
            bool[] isComposite = new bool[max + 1];

            for (int i = 2; i <= max; i++)
            {
                if (!isComposite[i])
                {
                    primes.Add(i);

                    for (int j = i * i; j <= max; j += i)
                    {
                        isComposite[j] = true;
                    }
                }
            }

            return primes;
        }
    }
}