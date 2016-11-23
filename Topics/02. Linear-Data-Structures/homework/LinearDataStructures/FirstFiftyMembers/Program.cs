namespace FirstFiftyMembers
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            int members = 50;
            var resultList = new List<int>();
            string input = Console.ReadLine();
            if (!IsStringValidNumber(input))
            {
                Console.WriteLine("This program works with numbers only. Refresh yorself, get a Beer!");
            }

            int n = int.Parse(input);
            var queue = new Queue<int>();

            queue.Enqueue(n);
            resultList.Add(n);

            while (true)
            {
                int current = queue.Dequeue();

                if (resultList.Count == members)
                {
                    break;
                }

                queue.Enqueue(current + 1);
                resultList.Add(current + 1);

                if (resultList.Count == members)
                {
                    break;
                }

                queue.Enqueue((2 * current) + 1);
                resultList.Add((2 * current) + 1);

                if (resultList.Count == members)
                {
                    break;
                }

                queue.Enqueue(current + 2);
                resultList.Add(current + 2);

                if (resultList.Count == members)
                {
                    break;
                }
            }

            Console.WriteLine(string.Join(", ", resultList));
        }

        private static bool IsStringValidNumber(string number)
        {
            int parsedNumber = 1;
            int.TryParse(number, out parsedNumber);
            return parsedNumber != 0 ? true : false;
        }
    }
}
