using System;

namespace DiagonalMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            // - Create (dynamically) a two dimensional array
            //   with the following matrix. Use a loop!
            //
            //   1 0 0 0
            //   0 1 0 0
            //   0 0 1 0
            //   0 0 0 1
            //
            // - Print this two dimensional array to the output
            int[,] matrix = new int [4, 4];
            //matrix[0] = new int[] {1, 0, 0, 0};
            //matrix[1] = new int[] { 0, 1, 0, 0};
            //matrix[2] = new int[] { 0, 0, 1, 0};
            //matrix[3] = new int[] { 0, 0, 0, 1};

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        matrix[i, j] = 1;
                    }
                    else
                    {
                        matrix[i, j] = 0;
                    }
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
