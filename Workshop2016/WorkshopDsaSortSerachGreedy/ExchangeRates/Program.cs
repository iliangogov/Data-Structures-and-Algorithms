using System;
using System.Linq;

class Program
{
    static void Main()
    {
        var c = double.Parse(Console.ReadLine());
        var c2 = 0.00;
        var days = int.Parse(Console.ReadLine());
        var maxCurr1 = 0.00;
        var maxCurr2 = 0.00;

        for (int i = 0; i < days; i++)
        {
            var exchange = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(double.Parse).ToArray();

            var curr1 = Math.Max(c2 * exchange[1], c);
            var curr2 = Math.Max(c * exchange[0], c2);

            maxCurr1 = Math.Max(curr1, maxCurr1);
            maxCurr2 = Math.Max(curr2, maxCurr2);

            c = curr1;
            c2 = curr2;
        }
        Console.WriteLine("{0:F2}", maxCurr1);
    }
}
