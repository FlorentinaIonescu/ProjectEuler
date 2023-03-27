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

        static void Main(string[] args)
        {
            const int gridSize = 20;
            long[,] grid = new long[gridSize + 1, gridSize + 1];

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
        }
    }
}