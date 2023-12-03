using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module14PW
{
    public class Class1
    {
        static void Main()
        {
            string text = "Вот дом, Который построил Джек. А это пшеница, Которая в темном чулане хранится В доме, Который построил Джек. А это веселая птица-синица, Которая часто ворует пшеницу, Которая в темном чулане хранится В доме, Который построил Джек.";

            Dictionary<string, int> wordCount = CountWords(text);

            DisplayStatistics(wordCount);
        }

        static Dictionary<string, int> CountWords(string text)
        {
            string[] words = text.Split(new char[] { ' ', ',', '.', '-', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> wordCount = new Dictionary<string, int>();

            foreach (string word in words)
            {
                string cleanedWord = word.ToLower();
                if (wordCount.ContainsKey(cleanedWord))
                {
                    wordCount[cleanedWord]++;
                }
                else
                {
                    wordCount[cleanedWord] = 1;
                }
            }

            return wordCount;
        }

        static void DisplayStatistics(Dictionary<string, int> wordCount)
        {
            Console.WriteLine("Word\t\tCount");
            Console.WriteLine("------------------------");

            foreach (var pair in wordCount)
            {
                Console.WriteLine($"{pair.Key}\t\t{pair.Value}");
            }
        }
    }
}
