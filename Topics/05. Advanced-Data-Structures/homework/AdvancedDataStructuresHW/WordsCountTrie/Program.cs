﻿namespace WordsCountTrie
{
    using Products;
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;

    public static class Startup
    {
        private const string LoremPath = "../../Files/lorem.txt";

        public static void Main()
        {
            Console.WriteLine("Generating big lorem text. Please stand by...for a 10 seconds...");
            RandomDataGenerator.GenerateLorem(LoremPath);

            var trie = TrieFactory.CreateTrie();
            var wordsSet = new List<string>(1000);

            Console.WriteLine("Reading words from file...");
            var words = File.ReadAllLines(LoremPath).SelectMany(x => x.Split(new[] { ' ', ',', '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries));

            Console.WriteLine("Saving words...");
            foreach (var word in words)
            {
                trie.AddWord(word);

                if (!wordsSet.Contains(word) && wordsSet.Count < 999)
                {
                    wordsSet.Add(word);
                }
            }

            var sb = new StringBuilder();

            Console.WriteLine("Counting words...");
            foreach (var word in wordsSet)
            {
                sb.AppendLine(string.Format("{0} occured {1} times in the text.", word, trie.WordCount(word)));
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
