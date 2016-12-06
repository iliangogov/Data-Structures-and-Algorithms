using System;
using System.Linq;

namespace Quicksort
{
    class Program
    {
        static void Main(string[] args)
        {
            int K = int.Parse(Console.ReadLine().Split(' ').ToArray()[1]);
            Console.WriteLine(Console.ReadLine().Split(' ').OrderBy(x=>x).ToArray()[K]);
        }
    }
}