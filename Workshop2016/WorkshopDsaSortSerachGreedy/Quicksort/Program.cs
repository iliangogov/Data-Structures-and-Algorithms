using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Quicksort
{
    class Program
    {
        static void Main(string[] args)
        {

            var numIndex = Console.ReadLine().Split(' ').ToArray();
            int N = int.Parse(numIndex[0]);
            int K = int.Parse(numIndex[1]);

            string[] strings = Console.ReadLine().Split(' ').ToArray();

            // Sort the array
            Quicksort(strings, 0, N - 1);

            //// Print the sorted array
            //for (int i = 0; i < strings.Length; i++)
            //{
            //    Console.Write(strings[i] + " ");
            //}

            Console.WriteLine(strings[K]);

            //Console.ReadLine();
        }

        public static void Quicksort(IComparable[] elements, int left, int right)
        {
            int i = left, j = right;
            IComparable pivot = elements[(left + right) / 2];

            while (i <= j)
            {
                while (elements[i].CompareTo(pivot) < 0)
                {
                    i++;
                }

                while (elements[j].CompareTo(pivot) > 0)
                {
                    j--;
                }

                if (i <= j)
                {
                    // Swap
                    IComparable tmp = elements[i];
                    elements[i] = elements[j];
                    elements[j] = tmp;

                    i++;
                    j--;
                }
            }

            // Recursive calls
            if (left < j)
            {
                Quicksort(elements, left, j);
            }

            if (i < right)
            {
                Quicksort(elements, i, right);
            }
        }

    }
}