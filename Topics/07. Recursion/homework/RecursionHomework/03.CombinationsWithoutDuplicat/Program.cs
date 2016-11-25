namespace _03.CombinationsWithoutDuplicat
{
    using System;
    using System.Text;

    /// <summary>
    /// Eurofootball columns calculator
    /// </summary>
    public class Program
    {
        private static StringBuilder sb;

        public static void Main()
        {
            Console.Write("Enter n (football games you wanna gamble): ");
            var n = int.Parse(Console.ReadLine());
            Console.Write("Enter k combinations (winning combinations for example 2 out of 3 is 3 columns): ");
            var k = int.Parse(Console.ReadLine());

            sb = new StringBuilder();

            Combine(1, n, 0, new int[k]);

            Console.WriteLine(sb.ToString());
        }

        private static void Combine(int firstNum, int lastNum, int index, int[] arr)
        {
            if (index >= arr.Length)
            {
                sb.AppendLine(string.Format("({0})", string.Join(" ", arr)));

                return;
            }

            for (int i = firstNum; i <= lastNum; i++)
            {
                arr[index] = i;

                Combine(i + 1, lastNum, index + 1, arr);
            }
        }
    }
}
