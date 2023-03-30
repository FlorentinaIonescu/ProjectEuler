using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public static class Problem60
    {
        // The primes 3, 7, 109, and 673, are quite remarkable.By taking any two primes and concatenating them in any order the result will always be prime. For example, taking 7 and 109, both 7109 and 1097 are prime. The sum of these four primes, 792, represents the lowest sum for a set of four primes with this property.
        // Find the lowest sum for a set of five primes for which any two primes concatenate to produce another prime.

        public static void Run()
        {
            int limit = 10000;
            List<int> primes = GetPrimes(limit);

            int[] primeArray = primes.ToArray();

            int sum = 0;
            int count = 0;

            for (int i = 1; i < primeArray.Length && count < 5; i++)
            {
                for (int j = i + 1; j < primeArray.Length && count < 5; j++)
                {
                    if (IsConcatenatedPrime(primeArray[i], primeArray[j], primes) &&
                        IsConcatenatedPrime(primeArray[j], primeArray[i], primes))
                    {
                        for (int k = j + 1; k < primeArray.Length && count < 5; k++)
                        {
                            if (IsConcatenatedPrime(primeArray[i], primeArray[k], primes) &&
                                IsConcatenatedPrime(primeArray[j], primeArray[k], primes) &&
                                IsConcatenatedPrime(primeArray[k], primeArray[i], primes) &&
                                IsConcatenatedPrime(primeArray[k], primeArray[j], primes))
                            {
                                for (int l = k + 1; l < primeArray.Length && count < 5; l++)
                                {
                                    if (IsConcatenatedPrime(primeArray[i], primeArray[l], primes) &&
                                        IsConcatenatedPrime(primeArray[j], primeArray[l], primes) &&
                                        IsConcatenatedPrime(primeArray[k], primeArray[l], primes) &&
                                        IsConcatenatedPrime(primeArray[l], primeArray[i], primes) &&
                                        IsConcatenatedPrime(primeArray[l], primeArray[j], primes) &&
                                        IsConcatenatedPrime(primeArray[l], primeArray[k], primes))
                                    {
                                        sum = primeArray[i] + primeArray[j] + primeArray[k] + primeArray[l];
                                        count++;
                                    }
                                }
                            }
                        }
                    }
                }
            }

            Console.WriteLine(sum);
        }

        static List<int> GetPrimes(int limit)
        {
            List<int> primes = new List<int>();
            primes.Add(2);

            for (int i = 3; i <= limit; i += 2)
            {
                bool isPrime = true;

                for (int j = 2; j <= Math.Sqrt(i); j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    primes.Add(i);
                }
            }

            return primes;
        }

        static bool IsConcatenatedPrime(int a, int b, List<int> primes)
        {
            string str1 = a.ToString() + b.ToString();
            string str2 = b.ToString() + a.ToString();

            int num1 = Int32.Parse(str1);
            int num2 = Int32.Parse(str2);

            return primes.Contains(num1) && primes.Contains(num2);
        }
    }
}