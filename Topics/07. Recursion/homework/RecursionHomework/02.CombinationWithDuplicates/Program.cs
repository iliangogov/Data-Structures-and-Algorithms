namespace _02.CombinationWithDuplicates
{
    using System;
    using System.Text;

    public class Program
    {
        private static StringBuilder sb;

        public static void Main()
        {
            Console.Write("Enter n combinations: ");
            var n = int.Parse(Console.ReadLine());
            Console.Write("Enter k elements : ");
            var k = int.Parse(Console.ReadLine());

            sb = new StringBuilder();

            Combine(1, n, 0, new int[k]);

            Console.WriteLine(sb.ToString());
        }

        private static void Combine(int firstNum, int lastNum, int index, int[] arr)
        {
            for (int i = firstNum; i <= lastNum; i++)
            {
                if (index >= arr.Length)
                {
                    sb.AppendLine(string.Format("({0})", string.Join(" ", arr)));

                    return;
                }

                arr[index] = i;

                Combine(i, lastNum, index + 1, arr);
            }
        }
    }
}
