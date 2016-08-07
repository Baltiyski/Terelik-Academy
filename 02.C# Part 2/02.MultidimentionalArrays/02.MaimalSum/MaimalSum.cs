using System;
using System.Collections.Generic;
using System.Linq;

class MaimalSum
{
    static void Main(string[] args)
    {
        int[] size = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int rows = size.First();
        int cols = size.Last();

        int[,] matrix = new int[rows, cols];

        for (int row = 0; row < rows; row++)
        {
            string[] currentRowAsString = Console.ReadLine().Split(' ');

            for (int col = 0; col < cols; col++)
            {
                matrix[row, col] = int.Parse(currentRowAsString[col]);
            }
        }

        int bestSum = int.MinValue;
        int[,] maxSumMatrix = new int[3, 3];


        for (int row = 0; row < rows - 2; row++)
        {
            for (int col = 0; col < cols - 2; col++)
            {
                int currentSum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2]
                    + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2]
                    + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                if (currentSum > bestSum)
                {
                    bestSum = currentSum;

                    for (int i = 0; i < maxSumMatrix.GetLength(0); i++)
                    {
                        for (int j = 0; j < maxSumMatrix.GetLength(1); j++)
                        {
                            maxSumMatrix[i, j] = matrix[row + i, col + j];
                        }
                    }
                }
            }
        }

        Console.WriteLine( bestSum);

    }
}
