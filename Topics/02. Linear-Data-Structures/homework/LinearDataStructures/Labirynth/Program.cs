namespace Labirynth
{
    using System;

    public class Program
    {
        private const string UnreachableCell = "u";
        private const string WallCell = "x";
        private const string StartingCell = "*";
        private const string UnfilledCell = "0";

        private static readonly int[] RowsDeltas = { -1, 0, 1, 0 };

        private static readonly int[] ColsDeltas = { 0, 1, 0, -1 };

        public static void Main()
        {
            string[,] labyrinth =
            {
                {"0", "0", "0", "x", "0", "x"},
                {"0", "x", "0", "x", "0", "x"},
                {"0", "*", "x", "0", "x", "0"},
                {"0", "x", "0", "0", "0", "0"},
                {"0", "0", "0", "x", "x", "0"},
                {"0", "0", "0", "x", "0", "x"}
            };

            PrintMatrixBefore(labyrinth);

            var currentRow = 2;
            var currentCol = 1;

            TraverseLabyrinth(currentRow, currentCol, labyrinth, 0);

            PrintMatrix(labyrinth);
        }

        private static void TraverseLabyrinth(int currentRow, int currentCol, string[,] labyrinth, int step)
        {
            if (!IsValidMove(currentRow, currentCol, labyrinth))
            {
                return;
            }

            if (labyrinth[currentRow, currentCol] == WallCell)
            {
                return;
            }

            if (labyrinth[currentRow, currentCol] != StartingCell && labyrinth[currentRow, currentCol] != UnfilledCell && step > int.Parse(labyrinth[currentRow, currentCol]))
            {
                return;
            }

            labyrinth[currentRow, currentCol] = step.ToString();

            for (int i = 0; i < RowsDeltas.Length; i++)
            {
                TraverseLabyrinth(currentRow + RowsDeltas[i], currentCol + ColsDeltas[i], labyrinth, step + 1);
            }
        }

        private static void PrintMatrixBefore(string[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0,3} ", matrix[i, j]);
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }

        private static void PrintMatrix(string[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0,3} ", matrix[i, j] == "0" ? "u" : matrix[i, j]);
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }

        private static bool IsValidMove(int row, int col, string[,] labyrinth)
        {
            return (row >= 0 && row < labyrinth.GetLength(0))
                && (col >= 0 && col < labyrinth.GetLength(1));
        }
    }
}
