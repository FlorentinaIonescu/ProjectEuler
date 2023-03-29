using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public static class Problem33
    {
        // ...There are exactly four non-trivial examples of this type of fraction, less than one in value, and containing two digits in the numerator and denominator.
        // If the product of these four fractions is given in its lowest common terms, find the value of the denominator.

        // The program assumes that there is only one common digit between the numerator and denominator.
        // If there were multiple common digits, it would need to be modified to handle that case
        public static void Run()
        {
            int numeratorProduct = 1;
            int denominatorProduct = 1;

            // iterating through all possible two-digit numerators and denominators,
            // excluding those that are trivial (e.g. 30/50) or where there is no common digit between the numerator and denominator
            for (int numerator = 10; numerator <= 98; numerator++)
            {
                for (int denominator = numerator + 1; denominator <= 99; denominator++)
                {
                    if (numerator % 10 == 0 && denominator % 10 == 0) continue;

                    if (numerator % 11 == 0 && denominator % 11 == 0) continue;

                    double fraction = (double)numerator / denominator;
                    int commonDigit = GetCommonDigit(numerator, denominator);

                    if (commonDigit == -1) continue;

                    double reducedFraction = (double)(numerator / 10 + numerator % 10 * 0.1) / (denominator / 10 + denominator % 10 * 0.1);

                    // checks if the simplified fraction is equal to the original fraction
                    // if so, multiplies the numerator and denominator together
                    if (fraction == reducedFraction)
                    {
                        numeratorProduct *= numerator;
                        denominatorProduct *= denominator;
                    }
                }
            }

            // finds the GCD of the product of the numerators and the product of the denominators
            int gcd = GCD(numeratorProduct, denominatorProduct);

            // divides the denominator product by the GCD to get the answer
            if (gcd != 0)
            {
                Console.WriteLine(denominatorProduct / gcd);
            }
            
            Console.ReadLine();
        }

        static int GetCommonDigit(int numerator, int denominator)
        {
            int n1 = numerator / 10;
            int n2 = numerator % 10;
            int d1 = denominator / 10;
            int d2 = denominator % 10;

            if (n1 == d1 || n1 == d2) return n1;
            if (n2 == d1 || n2 == d2) return n2;

            return -1;
        }

        static int GCD(int a, int b)
        {
            if (a == 0) return b;
            if (b == 0) return a;

            return GCD(b, a % b);
        }
    }
}