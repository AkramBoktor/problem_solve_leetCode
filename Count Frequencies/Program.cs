using System;
using System.Collections.Generic;

namespace Count_Frequencies
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] repearde = Program.CountFrequencies(new string[] { "the", "dog", "the", "bone" });
            Console.WriteLine(repearde);
        }

        public static int[] CountFrequencies(string[] words)
        {
            // Write your code here
            // To debug: Console.Error.WriteLine("Debug messages...");
            List<string> newWords = new List<string>();
            int countOfDuplicatedWords = 0;
            List<int> repeatedWords = new List<int>();
            foreach (var word in words)
            {
                newWords.Add(word);
            }

            newWords.Sort();
            for (int i = 0; i < newWords.Count; i++)
            {
                countOfDuplicatedWords = 1;
                for (int j = i + 1; j < newWords.Count; j++)
                {
                    if (newWords[i] == newWords[j])
                    {
                        countOfDuplicatedWords++;
                        newWords.RemoveAt(j);
                    }
                }
                repeatedWords.Add(countOfDuplicatedWords);
            }

            return repeatedWords.ToArray();
           
        }

    }
}
