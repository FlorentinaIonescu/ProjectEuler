using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public static class Problem32
    {
        // We shall say that an n-digit number is pandigital if it makes use of all the digits 1 to n exactly once; for example, the 5-digit number, 15234, is 1 through 5 pandigital.
        // The product 7254 is unusual, as the identity, 39 × 186 = 7254, containing multiplicand, multiplier, and product is 1 through 9 pandigital.
        // Find the sum of all products whose multiplicand/multiplier/product identity can be written as a 1 through 9 pandigital.

        public static void Run()
        {
            HashSet<int> products = new HashSet<int>();

            // generates all possible combinations of two integers between 1 and 9999 (inclusive)
            for (int i = 1; i < 10000; i++)
            {
                // checks whether their product, together with the two integers themselves, form a pandigital number of length 9 (i.e., using each digit 1 through 9 exactly once)
                for (int j = i + 1; j < 10000; j++)
                {
                    int product = i * j;
                    string concatenated = i.ToString() + j.ToString() + product.ToString();

                    if (concatenated.Length == 9)
                    {
                        bool isPandigital = true;
                        bool[] digits = new bool[9];

                        for (int k = 0; k < 9; k++)
                        {
                            int digit = int.Parse(concatenated[k].ToString()) - 1;

                            if (digit < 0 || digit > 8 || digits[digit])
                            {
                                isPandigital = false;
                                break;
                            }

                            digits[digit] = true;
                        }

                        if (isPandigital)
                        {
                            products.Add(product); //the product is added to a HashSet to eliminate duplicates
                        }
                    }
                }
            }

            int sum = 0;
            foreach (int product in products)
            {
                sum += product;
            }

            Console.WriteLine(sum);
            Console.ReadLine();
        }
    }
}