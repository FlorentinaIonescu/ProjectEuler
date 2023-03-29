using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;
namespace ProjectEuler
{
    public static class Problem22
    {
        // Using names.txt(right click and 'Save Link/Target As...'), a 46K text file containing over five-thousand first names, begin by sorting it into alphabetical order.Then working out the alphabetical value for each name, multiply this value by its alphabetical position in the list to obtain a name score.
        // For example, when the list is sorted into alphabetical order, COLIN, which is worth 3 + 15 + 12 + 9 + 14 = 53, is the 938th name in the list.So, COLIN would obtain a score of 938 × 53 = 49714.
        // What is the total of all the name scores in the file?


        public static void Run()
        {
            // Read in the file containing the names
            var names = File.ReadAllText("p022_names.txt");

            // Split the names into an array and sort it
            var nameArray = names.Split(',')
                                 .Select(name => name.Trim('"'))
                                 .OrderBy(name => name)
                                 .ToArray();

            // Calculate the total score for all names
            long totalScore = 0;
            for (int i = 0; i < nameArray.Length; i++)
            {
                long nameScore = GetNameScore(nameArray[i]);
                totalScore += (i + 1) * nameScore;
            }

            Console.WriteLine($"The total score of all names is {totalScore}");
            Console.ReadLine();
        }

        static long GetNameScore(string name)
        {
            long nameScore = 0;
            foreach (char c in name)
            {
                nameScore += (long)(c - 'A') + 1;
            }
            return nameScore;
        }
    }
}