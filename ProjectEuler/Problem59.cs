using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace ProjectEuler
{
    public static class Problem59
    {
        // [XOR decryption]

        public static void Run()
        {
            string path = "p059_cipher.txt";
            string[] encryptedText = File.ReadAllText(path).Split(',').ToArray();

            // Brute force decryption
            for (char a = 'a'; a <= 'z'; a++)
            {
                for (char b = 'a'; b <= 'z'; b++)
                {
                    for (char c = 'a'; c <= 'z'; c++)
                    {
                        string decryptedText = Decrypt(encryptedText, a, b, c);
                        if (ContainsEnglishWords(decryptedText))
                        {
                            int sum = decryptedText.Sum(x => (int)x);
                            Console.WriteLine(sum);
                            return;
                        }
                    }
                }
            }
        }

        static string Decrypt(string[] encryptedText, char a, char b, char c)
        {
            string decryptedText = "";
            for (int i = 0; i < encryptedText.Length; i++)
            {
                char key = (i % 3 == 0) ? a : (i % 3 == 1) ? b : c;
                char decryptedChar = (char)(int.Parse(encryptedText[i]) ^ (int)key);
                decryptedText += decryptedChar;
            }
            return decryptedText;
        }

        static bool ContainsEnglishWords(string text)
        {
            string[] commonWords = { "the", "be", "to", "of", "and", "in", "that", "have", "it", "for", "not", "on", "with", "he", "as", "you", "do", "at", "this", "but", "his", "by", "from", "they", "we", "say", "her", "she", "or", "an", "will", "my", "one", "all", "would", "there", "their", "what", "so", "up", "out", "if", "about", "who", "get", "which", "go", "me", "when", "make", "can", "like", "time", "no", "just", "him", "know", "take", "person", "into", "year", "your", "good", "some", "could", "them", "see", "other", "than", "then", "now", "look", "only", "come", "its", "over", "think", "also", "back", "after", "use", "two", "how", "our", "work", "first", "well", "way", "even", "new", "want", "because", "any", "these", "give", "day", "most", "us" };
            string[] words = text.ToLower().Split(' ', '.', ',', '!', '?');
            int count = words.Count(w => commonWords.Contains(w));
            return count > words.Length / 10;
        }
    }
}
