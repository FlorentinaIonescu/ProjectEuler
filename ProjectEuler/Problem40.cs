using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public static class Problem40
    {
        // Champernowne's constant

        public static void Run()
        {
            int[] digitPositions = { 1, 10, 100, 1000, 10000, 100000, 1000000 }; //array to store the positions of the digits that we want to multiply together
            int product = 1;
            int digitCount = 0;
            int currentNumber = 1;

            for (int i = 0; i < digitPositions.Length; i++)
            {
                // Incrementing a digitCount variable until we reach the specified digit position 
                // Check if we've reached the specified digit position.
                // If so, we use string manipulation to extract the correct digit from the current number and multiply it into the product variable
                while (digitCount < digitPositions[i])
                {
                    digitCount += (int)Math.Log10(currentNumber) + 1;

                    if (digitCount >= digitPositions[i])
                    {
                        int digitIndex = currentNumber.ToString().Length - (digitCount - digitPositions[i]) - 1;
                        int digitValue = int.Parse(currentNumber.ToString()[digitIndex].ToString());
                        product *= digitValue;
                    }

                    currentNumber++;
                }
            }

            Console.WriteLine("The product of the specified digits is {0}", product);
            Console.ReadLine();
        }
    }
}