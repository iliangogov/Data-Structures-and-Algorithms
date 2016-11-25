namespace _01.NestedLoops
{
    using System;
    using System.Text;

    public static class Program
    {
        private static StringBuilder sb;

        public static void Main()
        {
            sb = new StringBuilder();

            Console.WriteLine("Enter number of loops and their depth:");
            var n = int.Parse(Console.ReadLine());
            SimulateLoop(n, n, new int[n]);

            Console.WriteLine(sb.ToString());
        }

        private static void SimulateLoop(int loops, int depth, int[] values)
        {
            if (depth == 0)
            {
                sb.AppendLine(string.Format(string.Join(" ", values)));
                return;
            }

            for (int i = 1; i <= loops; i++)
            {
                values[depth - 1] = i;
                SimulateLoop(loops, depth - 1, values);
            }
        }
    }
}
