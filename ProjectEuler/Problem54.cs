using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public static class Problem54
    {
        // [Poker Hands]

        //public static void Run()
        //{
        //    string input = File.ReadAllText("p054_poker.txt");
        //    string[] lines = input.Split('\n');
        //    int count = 0;
        //    foreach (string line in lines)
        //    {
        //        string[] cards = line.Trim().Split(' ');
        //        int[] values = cards.Select(card => "23456789TJQKA".IndexOf(card[0])).ToArray();
        //        char[] suits = cards.Select(card => card[1]).ToArray();
        //        Array.Sort(values);
        //        if (IsRoyalFlush(values, suits) || IsStraightFlush(values, suits) || IsFourOfAKind(values) ||
        //            IsFullHouse(values) || IsFlush(suits) || IsStraight(values) || IsThreeOfAKind(values) ||
        //            IsTwoPairs(values) || IsOnePair(values))
        //        {
        //            count++;
        //        }
        //    }
        //    Console.WriteLine(count);
        //}

        //static bool IsRoyalFlush(int[] values, char[] suits)
        //{
        //    return IsFlush(suits) && values.SequenceEqual(new int[] { 10, 11, 12, 13, 14 });
        //}

        //static bool IsStraightFlush(int[] values, char[] suits)
        //{
        //    return IsFlush(suits) && IsStraight(values);
        //}

        //static bool IsFourOfAKind(int[] values)
        //{
        //    return values.GroupBy(v => v).Any(g => g.Count() == 4);
        //}

        //static bool IsFullHouse(int[] values)
        //{
        //    return values.GroupBy(v => v).Count() == 2 && values.GroupBy(v => v).All(g => g.Count() == 2 || g.Count() == 3);
        //}

        //static bool IsFlush(char[] suits)
        //{
        //    return suits.All(s => s == suits[0]);
        //}

        //static bool IsStraight(int[] values)
        //{
        //    return values[4] - values[0] == 4 && values.Distinct().Count() == 5;
        //}

        //static bool IsThreeOfAKind(int[] values)
        //{
        //    return values.GroupBy(v => v).Any(g => g.Count() == 3);
        //}

        //static bool IsTwoPairs(int[] values)
        //{
        //    return values.GroupBy(v => v).Count() == 3 && values.GroupBy(v => v).All(g => g.Count() == 2 || g.Count() == 1);
        //}

        //static bool IsOnePair(int[] values)
        //{
        //    return values.GroupBy(v => v).Any(g => g.Count() == 2);
        //}

        public static void Run()
        {
            string filename = "p054_poker.txt";
            int player1Wins = 0;

            using (StreamReader reader = new StreamReader(filename))
            {
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    string[] cards = line.Split(' ');

                    int[] values = new int[5];
                    for (int i = 0; i < 5; i++)
                    {
                        char valueChar = cards[i][0];
                        switch (valueChar)
                        {
                            case '2': values[i] = 0; break;
                            case '3': values[i] = 1; break;
                            case '4': values[i] = 2; break;
                            case '5': values[i] = 3; break;
                            case '6': values[i] = 4; break;
                            case '7': values[i] = 5; break;
                            case '8': values[i] = 6; break;
                            case '9': values[i] = 7; break;
                            case 'T': values[i] = 8; break;
                            case 'J': values[i] = 9; break;
                            case 'Q': values[i] = 10; break;
                            case 'K': values[i] = 11; break;
                            case 'A': values[i] = 12; break;
                            default: throw new ArgumentException($"Invalid card value: {cards[i]}");
                        }
                    }

                    Array.Sort(values);
                    bool isFlush = true;
                    bool isStraight = true;

                    for (int i = 1; i < 5; i++)
                    {
                        if (cards[i][1] != cards[i - 1][1])
                        {
                            isFlush = false;
                        }
                        if (values[i] != values[i - 1] + 1)
                        {
                            isStraight = false;
                        }
                    }

                    if (isFlush && isStraight)
                    {
                        player1Wins++;
                    }
                }
            }

            Console.WriteLine($"Player 1 wins: {player1Wins}");
        }
    }
}