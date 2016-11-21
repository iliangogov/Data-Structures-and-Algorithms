namespace RemoveNegativeNumbers
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

            while (currentNumber != string.Empty)
            {
                Console.WriteLine("Enter a number:");
                int parsedNumber = int.Parse(currentNumber);
                sequence.Add(parsedNumber);
                currentNumber = Console.ReadLine();
            }

            Console.WriteLine("All numbers:");
            Console.Write(string.Join(", ", sequence));
            Console.WriteLine();

            foreach (var number in sequence)
            {
                if (number >= 0)
                {
                    nonNegativeSequence.Add(number);
                }
            }

            Console.WriteLine("Non negative numbers:");
            Console.Write(string.Join(", ", nonNegativeSequence));
            Console.WriteLine();
        }
    }
}
