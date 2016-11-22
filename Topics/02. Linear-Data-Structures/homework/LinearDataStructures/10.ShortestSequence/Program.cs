namespace _10.ShortestSequence
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            var resultList = new List<int>();
            string inputN = Console.ReadLine();
            string inputM = Console.ReadLine();

            if (!IsStringValidNumber(inputN) || !IsStringValidNumber(inputM))
            {
                Console.WriteLine("This program works with numbers only. Refresh yorself, get a Beer!");
            }

            int n = int.Parse(inputN);
            int m = int.Parse(inputM);
            var queue = new Queue<int>();

            queue.Enqueue(m);
            resultList.Add(m);

            while (n < queue.Peek())
            {
                if (queue.Count == 0)
                {
                    break;
                }

                int current = queue.Peek();

                if (current / 2 >= n && current % 2 == 0)
                {
                    resultList.Add(current / 2);
                    queue.Enqueue(current / 2);
                    queue.Dequeue();
                    continue;
                }

                if (queue.Count == 0)
                {
                    break;
                }

                if (queue.Peek() - 2 >= n)
                {
                    resultList.Add(queue.Peek() - 2);
                    queue.Enqueue(queue.Peek() - 2);
                    queue.Dequeue();
                    continue;
                }

                if (queue.Count == 0)
                {
                    break;
                }

                if (queue.Peek() - 1 >= n)
                {
                    resultList.Add(queue.Peek() - 1);
                    queue.Enqueue(queue.Peek() - 1);
                    queue.Dequeue();
                    continue;
                }
            }

            resultList.Sort();
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
