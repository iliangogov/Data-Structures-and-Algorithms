namespace QueueImplementation
{
    using System;

    public class Program
    {
        public static void Main(string[] args)
        {
            var queue = new LinkedQueue<int>();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);

            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine(queue.Dequeue());
            Console.WriteLine("Queue count remaining {0}", queue.Count());
        }
    }
}
