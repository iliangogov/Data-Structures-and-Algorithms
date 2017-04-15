namespace LongestSubsequence
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter a number:");
            string currentNumber = Console.ReadLine();
            //var sequence = new List<int>();
            var sequence = new Dictionary<int, int>();

            while (currentNumber != string.Empty)
            {
                Console.WriteLine("Enter a number:");
                int parsedNumber = int.Parse(currentNumber);
                if (!sequence.ContainsKey(parsedNumber))
                {
                    sequence.Add(parsedNumber, 1);
                }
                else
                {
                    sequence[parsedNumber] += 1;
                }
               
                currentNumber = Console.ReadLine();
            }

            int maxOccurances = 0;
            foreach(int val in sequence.Values)
            {
                if (val > maxOccurances)
                {
                    maxOccurances = val;
                }
            }

            Console.WriteLine(maxOccurances);
            //sequence.Sort();

            //int prevNum = sequence[0];
            //int equalSequenceCount = 1;
            //int count = 1;

            //for (int i = 1; i < sequence.Count; i++)
            //{
            //    int nextNum = sequence[i];
            //    if (nextNum == prevNum)
            //    {
            //        count++;
            //    }
            //    else
            //    {
            //        count = 1;
            //    }

            //    if (count > equalSequenceCount)
            //    {
            //        equalSequenceCount = count;
            //    }

            //    prevNum = nextNum;
            //}

            // Console.WriteLine(equalSequenceCount);
        }
    }
}
