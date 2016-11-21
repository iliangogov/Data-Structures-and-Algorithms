namespace SortSequenceInListOfInts
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

            while (currentNumber != string.Empty)
            {
                Console.WriteLine("Enter a number:");
                int parsedNumber = int.Parse(currentNumber);
                sequence.Add(parsedNumber);
                currentNumber = Console.ReadLine();
            }

            sequence.Sort();
            Console.WriteLine("Sorted in increasing order");
            foreach (var number in sequence)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine();
        }
    }
}
