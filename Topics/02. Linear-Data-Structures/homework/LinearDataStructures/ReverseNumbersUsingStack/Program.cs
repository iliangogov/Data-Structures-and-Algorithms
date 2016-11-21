namespace ReverseNumbersUsingStack
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter the count of numbers you'll enter:");
            int totalNumbers = int.Parse(Console.ReadLine());
            var stack = new Stack<int>();

            for (int i = 0; i < totalNumbers; i++)
            {
                Console.WriteLine("Enter a number:");
                var currentNumber = int.Parse(Console.ReadLine());
                stack.Push(currentNumber);
            }

            Console.WriteLine("Here are reversed numbers you entered:");
            while (stack.Count > 0)
            {
                var number = stack.Pop();
                Console.WriteLine(number + Environment.NewLine);
            }
        }
    }
}
