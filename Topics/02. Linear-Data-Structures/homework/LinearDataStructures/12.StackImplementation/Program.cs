namespace _12.StackImplementation
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            var stack = new Stack<int>();

            stack.Push(1);
            stack.Push(2);
            Console.WriteLine("Pop: " + stack.Pop());

            stack.Push(3);
            stack.Push(4);
            Console.WriteLine("Peek: " + stack.Peek());

            stack.Push(5);
            Console.WriteLine("Pop: " + stack.Pop());

            Console.WriteLine("2 and 5 should be missing because Pop command");
            Console.WriteLine(string.Join(" -> ", stack));
        }
    }
}
