using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public static class Problem11
    {
        // ...What is the greatest product of four adjacent numbers in the same direction (up, down, left, right, or diagonally) in the 20×20 grid?

        static void Main(string[] args)
        {
            int[,] grid = new int[20, 20]; // Define the grid as a 20x20 array of integers

            // Populate the grid with values
            grid[0, 0] = 8;
            grid[0, 1] = 2;
            grid[0, 2] = 22;
            grid[0, 3] = 22;
            grid[0, 4] = 22;
            grid[0, 5] = 22;
            grid[0, 6] = 22;
            grid[0, 7] = 22;
            grid[0, 8] = 22;
            grid[0, 9] = 22;
            grid[0, 10] = 22;
            grid[0, 11] = 22;
            grid[0, 12] = 22;
            grid[0, 13] = 22;
            grid[0, 14] = 22;
            grid[0, 15] = 22;
            grid[0, 16] = 22;
            grid[0, 17] = 22;
            grid[0, 18] = 22;
            grid[0, 19] = 22;
            grid[1, 0] = 8;
            grid[1, 1] = 2;
            grid[1, 2] = 22;
            grid[1, 3] = 22;
            grid[1, 4] = 22;
            grid[1, 5] = 22;
            grid[1, 6] = 22;
            grid[1, 7] = 22;
            grid[1, 8] = 22;
            grid[1, 9] = 22;
            grid[1, 10] = 22;
            grid[1, 11] = 22;
            grid[1, 12] = 22;
            grid[1, 13] = 22;
            grid[1, 14] = 22;
            grid[1, 15] = 22;
            grid[1, 16] = 22;
            grid[1, 17] = 22;
            grid[1, 18] = 22;
            grid[1, 19] = 22;
            grid[2, 0] = 8;
            grid[2, 1] = 2;
            grid[2, 2] = 22;
            grid[2, 3] = 22;
            grid[2, 4] = 22;
            grid[2, 5] = 22;
            grid[2, 6] = 22;
            grid[2, 7] = 22;
            grid[2, 8] = 22;
            grid[2, 9] = 22;
            grid[2, 10] = 22;
            grid[2, 11] = 22;
            grid[2, 12] = 22;
            grid[2, 13] = 22;
            grid[2, 14] = 22;
            grid[2, 15] = 22;
            grid[2, 16] = 22;
            grid[2, 17] = 22;
            grid[2, 18] = 22;
            grid[2, 19] = 22;
            grid[3, 0] = 8;
            grid[3, 1] = 2;
            grid[3, 2] = 22;
            grid[3, 3] = 22;
            grid[3, 4] = 22;
            grid[3, 5] = 22;
            grid[3, 6] = 22;
            grid[3, 7] = 22;
            grid[3, 8] = 22;
            grid[3, 9] = 22;
            grid[3, 10] = 22;
            grid[3, 11] = 22;
            grid[3, 12] = 22;
            grid[3, 13] = 22;
            grid[3, 14] = 22;
            grid[3, 15] = 22;
            grid[3, 16] = 22;
            grid[3, 17] = 22;
            grid[3, 18] = 22;
            grid[3, 19] = 22;
            grid[4, 0] = 8;
            grid[4, 1] = 2;
            grid[4, 2] = 22;
            grid[4, 3] = 22;
            grid[4, 4] = 22;
            grid[4, 5] = 22;
            grid[4, 6] = 22;
            grid[4, 7] = 22;
            grid[4, 8] = 22;
            grid[4, 9] = 22;
            grid[4, 10] = 22;
            grid[4, 11] = 22;
            grid[4, 12] = 22;
            grid[4, 13] = 22;
            grid[4, 14] = 22;
            grid[4, 15] = 22;
            grid[4, 16] = 22;
            grid[4, 17] = 22;
            grid[4, 18] = 22;
            grid[4, 19] = 22;
            grid[5, 0] = 8;
            grid[5, 1] = 2;
            grid[5, 2] = 22;
            grid[5, 3] = 22;
            grid[5, 4] = 22;
            grid[5, 5] = 22;
            grid[5, 6] = 22;
            grid[5, 7] = 22;
            grid[5, 8] = 22;
            grid[5, 9] = 22;
            grid[5, 10] = 22;
            grid[5, 11] = 22;
            grid[5, 12] = 22;
            grid[5, 13] = 22;
            grid[5, 14] = 22;
            grid[5, 15] = 22;
            grid[5, 16] = 22;
            grid[5, 17] = 22;
            grid[5, 18] = 22;
            grid[5, 19] = 22;
            grid[6, 0] = 8;
            grid[6, 1] = 2;
            grid[6, 2] = 22;
            grid[6, 3] = 22;
            grid[6, 4] = 22;
            grid[6, 5] = 22;
            grid[6, 6] = 22;
            grid[6, 7] = 22;
            grid[6, 8] = 22;
            grid[6, 9] = 22;
            grid[6, 10] = 22;
            grid[6, 11] = 22;
            grid[6, 12] = 22;
            grid[6, 13] = 22;
            grid[6, 14] = 22;
            grid[6, 15] = 22;
            grid[6, 16] = 22;
            grid[6, 17] = 22;
            grid[6, 18] = 22;
            grid[6, 19] = 22;
            grid[7, 0] = 8;
            grid[7, 1] = 2;
            grid[7, 2] = 22;
            grid[7, 3] = 22;
            grid[7, 4] = 22;
            grid[7, 5] = 22;
            grid[7, 6] = 22;
            grid[7, 7] = 22;
            grid[7, 8] = 22;
            grid[7, 9] = 22;
            grid[7, 10] = 22;
            grid[7, 11] = 22;
            grid[7, 12] = 22;
            grid[7, 13] = 22;
            grid[7, 14] = 22;
            grid[7, 15] = 22;
            grid[7, 16] = 22;
            grid[7, 17] = 22;
            grid[7, 18] = 22;
            grid[7, 19] = 22;
            grid[8, 0] = 8;
            grid[8, 1] = 2;
            grid[8, 2] = 22;
            grid[8, 3] = 22;
            grid[8, 4] = 22;
            grid[8, 5] = 22;
            grid[8, 6] = 22;
            grid[8, 7] = 22;
            grid[8, 8] = 22;
            grid[8, 9] = 22;
            grid[8, 10] = 22;
            grid[8, 11] = 22;
            grid[8, 12] = 22;
            grid[8, 13] = 22;
            grid[8, 14] = 22;
            grid[8, 15] = 22;
            grid[8, 16] = 22;
            grid[8, 17] = 22;
            grid[8, 18] = 22;
            grid[8, 19] = 22;
            grid[9, 0] = 8;
            grid[9, 1] = 2;
            grid[9, 2] = 22;
            grid[9, 3] = 22;
            grid[9, 4] = 22;
            grid[9, 5] = 22;
            grid[9, 6] = 22;
            grid[9, 7] = 22;
            grid[9, 8] = 22;
            grid[9, 9] = 22;
            grid[9, 10] = 22;
            grid[9, 11] = 22;
            grid[9, 12] = 22;
            grid[9, 13] = 22;
            grid[9, 14] = 22;
            grid[9, 15] = 22;
            grid[9, 16] = 22;
            grid[9, 17] = 22;
            grid[9, 18] = 22;
            grid[9, 19] = 22;
            grid[10, 0] = 8;
            grid[10, 1] = 2;
            grid[10, 2] = 22;
            grid[10, 3] = 22;
            grid[10, 4] = 22;
            grid[10, 5] = 22;
            grid[10, 6] = 22;
            grid[10, 7] = 22;
            grid[10, 8] = 22;
            grid[10, 9] = 22;
            grid[10, 10] = 22;
            grid[10, 11] = 22;
            grid[10, 12] = 22;
            grid[10, 13] = 22;
            grid[10, 14] = 22;
            grid[10, 15] = 22;
            grid[10, 16] = 22;
            grid[10, 17] = 22;
            grid[10, 18] = 22;
            grid[10, 19] = 22;
            grid[11, 0] = 8;
            grid[11, 1] = 2;
            grid[11, 2] = 22;
            grid[11, 3] = 22;
            grid[11, 4] = 22;
            grid[11, 5] = 22;
            grid[11, 6] = 22;
            grid[11, 7] = 22;
            grid[11, 8] = 22;
            grid[11, 9] = 22;
            grid[11, 10] = 22;
            grid[11, 11] = 22;
            grid[11, 12] = 22;
            grid[11, 13] = 22;
            grid[11, 14] = 22;
            grid[11, 15] = 22;
            grid[11, 16] = 22;
            grid[11, 17] = 22;
            grid[11, 18] = 22;
            grid[11, 19] = 22;
            grid[12, 0] = 8;
            grid[12, 1] = 2;
            grid[12, 2] = 22;
            grid[12, 3] = 22;
            grid[12, 4] = 22;
            grid[12, 5] = 22;
            grid[12, 6] = 22;
            grid[12, 7] = 22;
            grid[12, 8] = 22;
            grid[12, 9] = 22;
            grid[12, 10] = 22;
            grid[12, 11] = 22;
            grid[12, 12] = 22;
            grid[12, 13] = 22;
            grid[12, 14] = 22;
            grid[12, 15] = 22;
            grid[12, 16] = 22;
            grid[12, 17] = 22;
            grid[12, 18] = 22;
            grid[12, 19] = 22;
            grid[13, 0] = 8;
            grid[13, 1] = 2;
            grid[13, 2] = 22;
            grid[13, 3] = 22;
            grid[13, 4] = 22;
            grid[13, 5] = 22;
            grid[13, 6] = 22;
            grid[13, 7] = 22;
            grid[13, 8] = 22;
            grid[13, 9] = 22;
            grid[13, 10] = 22;
            grid[13, 11] = 22;
            grid[13, 12] = 22;
            grid[13, 13] = 22;
            grid[13, 14] = 22;
            grid[13, 15] = 22;
            grid[13, 16] = 22;
            grid[13, 17] = 22;
            grid[13, 18] = 22;
            grid[13, 19] = 22;
            grid[14, 0] = 8;
            grid[14, 1] = 2;
            grid[14, 2] = 22;
            grid[14, 3] = 22;
            grid[14, 4] = 22;
            grid[14, 5] = 22;
            grid[14, 6] = 22;
            grid[14, 7] = 22;
            grid[14, 8] = 22;
            grid[14, 9] = 22;
            grid[14, 10] = 22;
            grid[14, 11] = 22;
            grid[14, 12] = 22;
            grid[14, 13] = 22;
            grid[14, 14] = 22;
            grid[14, 15] = 22;
            grid[14, 16] = 22;
            grid[14, 17] = 22;
            grid[14, 18] = 22;
            grid[14, 19] = 22;
            grid[15, 0] = 8;
            grid[15, 1] = 2;
            grid[15, 2] = 22;
            grid[15, 3] = 22;
            grid[15, 4] = 22;
            grid[15, 5] = 22;
            grid[15, 6] = 22;
            grid[15, 7] = 22;
            grid[15, 8] = 22;
            grid[15, 9] = 22;
            grid[15, 10] = 22;
            grid[15, 11] = 22;
            grid[15, 12] = 22;
            grid[15, 13] = 22;
            grid[15, 14] = 22;
            grid[15, 15] = 22;
            grid[15, 16] = 22;
            grid[15, 17] = 22;
            grid[15, 18] = 22;
            grid[15, 19] = 22;
            grid[16, 0] = 8;
            grid[16, 1] = 2;
            grid[16, 2] = 22;
            grid[16, 3] = 22;
            grid[16, 4] = 22;
            grid[16, 5] = 22;
            grid[16, 6] = 22;
            grid[16, 7] = 22;
            grid[16, 8] = 22;
            grid[16, 9] = 22;
            grid[16, 10] = 22;
            grid[16, 11] = 22;
            grid[16, 12] = 22;
            grid[16, 13] = 22;
            grid[16, 14] = 22;
            grid[16, 15] = 22;
            grid[16, 16] = 22;
            grid[16, 17] = 22;
            grid[16, 18] = 22;
            grid[16, 19] = 22;
            grid[17, 0] = 8;
            grid[17, 1] = 2;
            grid[17, 2] = 22;
            grid[17, 3] = 22;
            grid[17, 4] = 22;
            grid[17, 5] = 22;
            grid[17, 6] = 22;
            grid[17, 7] = 22;
            grid[17, 8] = 22;
            grid[17, 9] = 22;
            grid[17, 10] = 22;
            grid[17, 11] = 22;
            grid[17, 12] = 22;
            grid[17, 13] = 22;
            grid[17, 14] = 22;
            grid[17, 15] = 22;
            grid[17, 16] = 22;
            grid[17, 17] = 22;
            grid[17, 18] = 22;
            grid[17, 19] = 22;
            grid[18, 0] = 8;
            grid[18, 1] = 2;
            grid[18, 2] = 22;
            grid[18, 3] = 22;
            grid[18, 4] = 22;
            grid[18, 5] = 22;
            grid[18, 6] = 22;
            grid[18, 7] = 22;
            grid[18, 8] = 22;
            grid[18, 9] = 22;
            grid[18, 10] = 22;
            grid[18, 11] = 22;
            grid[18, 12] = 22;
            grid[18, 13] = 22;
            grid[18, 14] = 22;
            grid[18, 15] = 22;
            grid[18, 16] = 22;
            grid[18, 17] = 22;
            grid[18, 18] = 22;
            grid[18, 19] = 22;
            grid[19, 17] = 14;
            grid[19, 18] = 89;
            grid[19, 19] = 15;

            long maxProduct = 0; // Initialize the maximum product to zero

            // Check horizontal products
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 17; j++)
                {
                    long product = grid[i, j] * grid[i, j + 1] * grid[i, j + 2] * grid[i, j + 3];
                    if (product > maxProduct)
                        maxProduct = product;
                }
            }

            // Check vertical products
            for (int i = 0; i < 17; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    long product = grid[i, j] * grid[i + 1, j] * grid[i + 2, j] * grid[i + 3, j];
                    if (product > maxProduct)
                        maxProduct = product;
                }
            }

            // Check diagonal products (top-left to bottom-right)
            for (int i = 0; i < 17; i++)
            {
                for (int j = 0; j < 17; j++)
                {
                    long product = grid[i, j] * grid[i + 1, j + 1] * grid[i + 2, j + 2] * grid[i + 3, j + 3];
                    if (product > maxProduct)
                        maxProduct = product;
                }
            }

            // Check diagonal products (bottom-left to top-right)
            for (int i = 3; i < 20; i++)
            {
                for (int j = 0; j < 17; j++)
                {
                    long product = grid[i, j] * grid[i - 1, j + 1] * grid[i - 2, j + 2] * grid[i - 3, j + 3];
                    if (product > maxProduct)
                        maxProduct = product;
                }
            }

            Console.WriteLine("The maximum product of four adjacent numbers in the 20x20 grid is: " + maxProduct);
            Console.ReadLine(); // Keep the console window open
        }
    }
}