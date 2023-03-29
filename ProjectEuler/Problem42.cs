using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public static class Problem42
    {
        // ...By converting each letter in a word to a number corresponding to its alphabetical position and adding these values we form a word value. For example, the word value for SKY is 19 + 11 + 25 = 55 = t10. If the word value is a triangle number then we shall call the word a triangle word.
        // Using words.txt(right click and 'Save Link/Target As...'), a 16K text file containing nearly two-thousand common English words, how many are triangle words?

        public static void Run()
        {
            // Read the words from the file
            string[] words = File.ReadAllText("words.txt")
                                .Split(new char[] { ',', '"' },
                                       StringSplitOptions.RemoveEmptyEntries);

            // Compute the maximum value of a word
            int maxVal = words.Max(w => w.ToCharArray().Sum(c => c - 'A' + 1));

            // Compute the triangle numbers up to the maximum value
            HashSet<int> triangleNumbers = new HashSet<int>();
            int n = 1;
            while (true)
            {
                int t = (n * (n + 1)) / 2;
                if (t > maxVal) break;
                triangleNumbers.Add(t);
                n++;
            }

            // Count the number of triangle words
            int count = words.Count(w => triangleNumbers.Contains(w.ToCharArray()
                                                                     .Sum(c => c - 'A' + 1)));

            Console.WriteLine(count);
            Console.ReadLine();
        }
    }
}