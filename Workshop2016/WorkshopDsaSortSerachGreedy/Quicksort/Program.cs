﻿using System;
using System.Linq;

namespace Quicksort
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            var list = Console.ReadLine().Split(' ').ToArray();
            Quicksort(list, 0, list.Length - 1);

            Console.WriteLine(list.ToList()[input[1]]);
        }

        public static void Quicksort(string[] elements, int left, int right)
        {
            int i = left, j = right;
            var pivot = elements[(left + right) / 2];

            while (i <= j)
            {
                while (string.Compare(elements[i], pivot, StringComparison.Ordinal) < 0)
                {
                    i++;
                }

                while (string.Compare(elements[j], pivot, StringComparison.Ordinal) > 0)
                {
                    j--;
                }

                if (i <= j)
                {
                    var tmp = elements[i];
                    elements[i] = elements[j];
                    elements[j] = tmp;

                    i++;
                    j--;
                }
            }

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