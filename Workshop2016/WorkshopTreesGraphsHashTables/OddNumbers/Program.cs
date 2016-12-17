using System;

namespace OddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());
            long res = long.Parse(Console.ReadLine());
            for (int i = 1; i < N; i++)
            {
                res=res^ long.Parse(Console.ReadLine());
            }

            Console.WriteLine(res);
        }
    }
}
