namespace Diameter
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public class Program
    {
        private static long max;
        private static long temp;
        private static ushort maxIndex;

        public static void Main()
        {
            Dictionary<ushort, int>[] relations = GenerateRelations();
            bool[] visited = new bool[relations.Length];

            CalculatePath(relations, visited, 0, 0);
            CalculatePath(relations, visited, maxIndex, 0);

            Console.WriteLine(max);
        }

        private static void CalculatePath(Dictionary<ushort, int>[] relations, bool[] visited, ushort destination, ushort source)
        {
            if (relations[destination].Count == 1 && relations[destination].ContainsKey(source))
            {
                if (temp > max)
                {
                    maxIndex = destination;
                    max = temp;
                }

                return;
            }

            visited[destination] = true;

            foreach (ushort key in relations[destination].Keys)
            {
                if (visited[key] != true)
                {
                    temp += relations[destination][key];
                    CalculatePath(relations, visited, key, destination);
                    temp -= relations[destination][key];
                }
            }

            visited[destination] = false;
        }

        private static Dictionary<ushort, int>[] GenerateRelations()
        {
            ushort count = ushort.Parse(Console.ReadLine());
            Dictionary<ushort, int>[] relations = new Dictionary<ushort, int>[count];

            for (int i = 0; i < relations.Length; ++i)
            {
                relations[i] = new Dictionary<ushort, int>();
            }

            for (int i = 0; i < count - 1; ++i)
            {
                int[] parameters = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
                relations[parameters[0]].Add((ushort)parameters[1], parameters[2]);
                relations[parameters[1]].Add((ushort)parameters[0], parameters[2]);
            }

            return relations;
        }
    }
}