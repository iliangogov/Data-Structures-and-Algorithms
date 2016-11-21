namespace Majorant
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
            var filteredSequence = new List<int>();

            while (currentNumber != string.Empty)
            {
                Console.WriteLine("Enter a number:");
                int parsedNumber = int.Parse(currentNumber);
                sequence.Add(parsedNumber);
                currentNumber = Console.ReadLine();
            }

            var majorantCoeficient = (sequence.Count / 2) + 1;
            bool isMajorantFound = false;

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

                if (!filteredSequence.Contains(number) && currMatchCount >= majorantCoeficient)
                {
                    isMajorantFound = true;
                    filteredSequence.Add(number);
                    Console.WriteLine($"Number {number} is majorant -> {currMatchCount} times");
                }

                currMatchCount = 0;
            }

            if (!isMajorantFound)
            {
                Console.WriteLine("No majorant in this sequence!");
            }
        }
    }
}
