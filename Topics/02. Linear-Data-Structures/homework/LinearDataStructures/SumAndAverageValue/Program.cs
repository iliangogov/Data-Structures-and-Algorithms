namespace SumAndAverageValue
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            string currentNumber = Console.ReadLine();
            var sequence = new List<int>();
            int sum = 0;
            int numbersCount = 0;
            bool correctInput = true;

            while (currentNumber != string.Empty)
            {
                if (!IsStringValidNumber(currentNumber))
                {
                    Console.WriteLine("This program calculates numbers only. Refresh yorself, get a Beer!");
                    correctInput = false;
                    break;
                }

                int parsedNumber = int.Parse(currentNumber);
                sequence.Add(parsedNumber);
                sum += parsedNumber;
                numbersCount += 1;
                currentNumber = Console.ReadLine();
            }

            if (correctInput)
            {
                int averageValue = sum / numbersCount;
                Console.WriteLine("Total sum of sequence is: {0}. Average value: {1}", sum, averageValue);
            }
        }

        private static bool IsStringValidNumber(string number)
        {
            int parsedNumber = 1;
            int.TryParse(number, out parsedNumber);
            return parsedNumber != 0 ? true : false;
        }
    }
}
