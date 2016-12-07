using System;

namespace SortingHomework
{
    class StartUp
    {
        public static void Main()
        {
            var list = new SortableCollection<string>();
            list.Add("a");
            list.Add("b");
            list.Add("c");
            list.Add("d");
            list.Add("e");
            list.Add("f");

            Console.WriteLine("Current collection:");
            list.PrintAllItemsOnConsole();
            Console.WriteLine("LinearSearch Demo. Is collection contains c?");
            Console.WriteLine(list.LinearSearch("c"));
            Console.WriteLine("LinearSearch Demo. Is collection contains g?");
            Console.WriteLine(list.LinearSearch("g"));
            Console.WriteLine("BinarySearch Demo. Is collection contains c?");
            Console.WriteLine(list.BinarySearch("c"));
            Console.WriteLine("LinearSearch Demo. Is collection contains g?");
            Console.WriteLine(list.BinarySearch("g"));
            Console.WriteLine("Shuffle Demo");
            list.Shuffle();
            list.PrintAllItemsOnConsole();
        }
    }
}
