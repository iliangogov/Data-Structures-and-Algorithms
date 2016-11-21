namespace RemoveOddTimesCount
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter a number:");
            string currentNumber = Console.ReadLine();
            var sequence = new List<int>();
            var nonNegativeSequence = new List<int>();
            var filteredSequence = new List<int>();

            while (currentNumber != string.Empty)
            {
                Console.WriteLine("Enter a number:");
                int parsedNumber = int.Parse(currentNumber);
                sequence.Add(parsedNumber);
                currentNumber = Console.ReadLine();
            }

            foreach (int number in sequence)
            {
                var currMatchCount = 0;

                for (int i = 0; i < sequence.Count; i++)
                {
                    if (number == sequence[i])
                    {
                        currMatchCount += 1;
                    }
                }

                if (currMatchCount % 2 == 0 && !filteredSequence.Contains(number))
                {
                    filteredSequence.Add(number);
                }

                currMatchCount = 0;
            }

            Console.WriteLine("filtered numbers:");
            Console.Write(string.Join(", ", filteredSequence));
            Console.WriteLine();
        }
    }
}
