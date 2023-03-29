using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public static class Problem43
    {
        // Find the sum of all 0 to 9 pandigital numbers with this property.

        // iterates over all pandigital numbers and adds the ones with the desired property to a sum
        public static void Run()
        {
            long sum = 0;
            var pandigitalNumbers = GetPandigitalNumbers();
            foreach (var pandigitalNumber in pandigitalNumbers)
            {
                if (HasSubstringDivisibilityProperty(pandigitalNumber))
                {
                    sum += pandigitalNumber;
                }
            }
            Console.WriteLine(sum);
            Console.ReadLine();
        }

        // generates all possible pandigital numbers of length 10
        static List<long> GetPandigitalNumbers()
        {
            var digits = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var pandigitalNumbers = new List<long>();
            GetPandigitalNumbersHelper(digits, "", pandigitalNumbers);
            return pandigitalNumbers;
        }

        static void GetPandigitalNumbersHelper(List<int> digits, string currentNumber, List<long> pandigitalNumbers)
        {
            if (digits.Count == 0)
            {
                pandigitalNumbers.Add(long.Parse(currentNumber));
            }
            else
            {
                for (int i = 0; i < digits.Count; i++)
                {
                    var newDigits = new List<int>(digits);
                    newDigits.RemoveAt(i);
                    GetPandigitalNumbersHelper(newDigits, currentNumber + digits[i], pandigitalNumbers);
                }
            }
        }

        // checks whether a given pandigital number has the substring divisibility property 
        static bool HasSubstringDivisibilityProperty(long number)
        {
            var digits = number.ToString().ToArray().Select(x => int.Parse(x.ToString())).ToArray();
            int[] primes = { 2, 3, 5, 7, 11, 13, 17 };
            for (int i = 1; i <= 7; i++)
            {
                var substring = digits[i] * 100 + digits[i + 1] * 10 + digits[i + 2];
                if (substring % primes[i - 1] != 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}