namespace _11.LinkedList
{
    using System;

    public class Program
    {
        public static void Main()
        {
            var linkedList = new LinkedList<string>();

            var firstItem = new ListItem<string>("First");

            linkedList.FirstItem = firstItem;

            var secondItem = new ListItem<string>("Second");

            firstItem.NextItem = secondItem;

            var thirdItem = new ListItem<string>("Third");

            secondItem.NextItem = thirdItem;

            Console.Write(string.Join("->", linkedList));

            Console.WriteLine();
        }
    }
}
