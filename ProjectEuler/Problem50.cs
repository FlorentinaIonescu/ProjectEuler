using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public static class Problem50
    {
        // The longest sum of consecutive primes below one-thousand that adds to a prime, contains 21 terms, and is equal to 953.
        // Which prime, below one-million, can be written as the sum of the most consecutive primes?

        public static void Run()
        {
            int maxNum = 1000000;
            bool[] isPrime = new bool[maxNum + 1];
            for (int i = 0; i <= maxNum; i++)
            {
                isPrime[i] = true;
            }
            isPrime[0] = false;
            isPrime[1] = false;
            for (int i = 2; i * i <= maxNum; i++)
            {
                if (isPrime[i])
                {
                    for (int j = i * i; j <= maxNum; j += i)
                    {
                        isPrime[j] = false;
                    }
                }
            }

            int[] primes = new int[maxNum];
            int numPrimes = 0;
            for (int i = 0; i <= maxNum; i++)
            {
                if (isPrime[i])
                {
                    primes[numPrimes] = i;
                    numPrimes++;
                }
            }

            int maxLength = 0;
            int maxPrime = 0;
            for (int i = 0; i < numPrimes; i++)
            {
                int sum = primes[i];
                int length = 1;
                for (int j = i + 1; j < numPrimes; j++)
                {
                    sum += primes[j];
                    length++;
                    if (sum > maxNum)
                    {
                        break;
                    }
                    if (isPrime[sum] && length > maxLength)
                    {
                        maxLength = length;
                        maxPrime = sum;
                    }
                }
            }

            Console.WriteLine(maxPrime);
            Console.ReadLine();
        }
    }
}