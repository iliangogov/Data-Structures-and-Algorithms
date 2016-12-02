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

            var elements = Console.ReadLine().Split(' ').ToArray();


            for (int i = 0; i < N; i++)
            {
                for (int j = i; j < N; j++)
                {
                    if(string.Compare(elements[i],elements[j])<0)
                    {
                        string temp = elements[i];

                    }
                }
            }
          
        }

      

    }
}