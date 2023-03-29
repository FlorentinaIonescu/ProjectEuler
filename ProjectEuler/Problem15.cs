using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public static class Problem15
    {
        // Starting in the top left corner of a 2×2 grid, and only being able to move to the right and down, there are exactly 6 routes to the bottom right corner.
        // How many such routes are there through a 20×20 grid?

        // dynamic programming
        // program uses the long data type to avoid overflow when computing large values
        public static void Run()
        {
            const int gridSize = 20; // initializing 2D array to store the number of routes to each point on the grid
            long[,] grid = new long[gridSize + 1, gridSize + 1]; //We initialize the first row and column to all be 1, since there is only one way to reach each point in the first row and column

            // we iterate through the remaining points in the grid and compute the number of routes to reach that point by adding the number of routes to the point to its left and the number of routes to the point above it
            for (int i = 0; i <= gridSize; i++)
            {
                for (int j = 0; j <= gridSize; j++)
                {
                    if (i == 0 || j == 0)
                    {
                        grid[i, j] = 1;
                    }
                    else
                    {
                        grid[i, j] = grid[i - 1, j] + grid[i, j - 1];
                    }
                }
            }

            Console.WriteLine("Number of routes in a {0}x{0} grid: {1}", gridSize, grid[gridSize, gridSize]);
            Console.ReadLine();
        }
    }
}