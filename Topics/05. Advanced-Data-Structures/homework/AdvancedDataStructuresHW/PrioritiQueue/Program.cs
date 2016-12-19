namespace PrioritiQueue
{
    using System;

    public static class Startup
    {
        public static void Main()
        {
            var Q = new PriorityQueue<int>();

            Q.Enqueue(18);
            Q.Enqueue(12);
            Q.Enqueue(3);
            Q.Enqueue(5);
            Q.Enqueue(6);
            Q.Enqueue(7);

            Console.WriteLine("Peek should return the top-most element of the min-heap (in this case 3): " + Q.Peek());

            int enqValue = 1;

            Console.WriteLine("\n\rEnqueued element with value " + enqValue);
            Q.Enqueue(enqValue);

            Console.WriteLine("\n\rPeek should return the top-most element of the min-heap (in this case 1): " + Q.Peek());

            Console.WriteLine("Dequeued element with value " + Q.Dequeue());
            Console.WriteLine("Dequeued element with value " + Q.Dequeue());
            Console.WriteLine("Dequeued element with value " + Q.Dequeue());
            Console.WriteLine("Dequeued element with value " + Q.Dequeue());
            Console.WriteLine("Dequeued element with value " + Q.Dequeue());

            enqValue = 4;
            Console.WriteLine("\n\rEnqueued element with value " + enqValue);
            Q.Enqueue(enqValue);

            enqValue = 8;
            Q.Enqueue(enqValue);
            Console.WriteLine("\n\rEnqueued element with value " + enqValue);

            Console.WriteLine("\n\rDequeued element with value " + Q.Dequeue());
            Console.WriteLine("Dequeued element with value " + Q.Dequeue());
            Console.WriteLine("Dequeued element with value " + Q.Dequeue());
        }
    }
}
