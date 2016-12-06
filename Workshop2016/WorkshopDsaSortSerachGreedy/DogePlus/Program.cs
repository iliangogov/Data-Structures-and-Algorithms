using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DogePlus
{
    class Program
    {
        static void Main(string[] args)
        {
            var RCK = Console.ReadLine().Split(' ').ToArray();
            var coords = Console.ReadLine().Split(';').ToArray();

            int R = int.Parse(RCK[0]);
            int C = int.Parse(RCK[1]);
            int K = int.Parse(RCK[2]);

            var matrix = new long[R, C];
            matrix[0, 0] = 0;
            matrix[0, 1] = 1;
            matrix[1, 0] = 1;

            foreach (var coord in coords)
            {
                var r = long.Parse(coord.Split(' ')[0]);
                var c = long.Parse(coord.Split(' ')[1]);

                matrix[r, c] = -1;
            }

            for (int rows = 0; rows < R; rows++)
            {

                for (int cols = 1; cols < C; cols++)
                {
                    if (rows == 0)
                    {
                        if (matrix[rows, cols] != -1)
                        {
                            if (matrix[rows, cols - 1] == -1)
                            {
                                matrix[rows, cols] = 0;
                            }
                            else
                            {
                                if (cols == 1)
                                {
                                    matrix[rows, cols] = matrix[rows, cols - 1] + 1;
                                }
                                else
                                {
                                    matrix[rows, cols] = matrix[rows, cols - 1];
                                }
                            }

                        }
                    }
                    else
                    {
                        if (cols == 1)
                        {
                            if (matrix[rows, cols - 1] != -1)
                            {
                                if (rows != 1)
                                    matrix[rows, cols - 1] = matrix[rows - 1, cols - 1];
                            }

                        }

                        if (matrix[rows, cols] != -1)
                        {
                            if (matrix[rows - 1, cols] != -1)
                            {
                                if (matrix[rows, cols - 1] != -1)
                                {
                                    matrix[rows, cols] = matrix[rows - 1, cols] + matrix[rows, cols - 1];
                                }
                                else
                                {
                                    matrix[rows, cols] = matrix[rows - 1, cols];
                                }
                            }
                            else
                            {
                                matrix[rows, cols] += matrix[rows, cols - 1];
                            }
                        }

                    }

                }
            }

            if (K > 0)
            {
                Console.WriteLine(matrix[R - 1, C - 1]* matrix[R - 1, C - 1]);
            }
            else
            {
                Console.WriteLine(matrix[R - 1, C - 1]);
            }

            PrintMatrix(matrix);
        }

        static void PrintMatrix(long[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int y = 0; y < matrix.GetLength(1); y++)
                {
                    Console.Write(matrix[i, y]);
                    Console.Write(' ');
                    Console.Write(' ');
                }
                Console.WriteLine();
            }
        }
    }
}
