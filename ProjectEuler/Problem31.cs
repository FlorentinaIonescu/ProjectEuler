using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public static class Problem31
    {
        // How many different ways can £2 be made using any number of coins?

        static int[] coins = { 1, 2, 5, 10, 20, 50, 100, 200 };
        static int target = 200;

        public static void Run()
        {
            Console.WriteLine(CountWays(target, coins.Length - 1));
            Console.ReadLine();
        }

        static int CountWays(int amount, int coinIndex)
        {
            if (amount == 0)
                return 1;

            if (amount < 0 || coinIndex < 0)
                return 0;

            return CountWays(amount - coins[coinIndex], coinIndex) + CountWays(amount, coinIndex - 1);
        }
    }
}