using System;

class SpiralMatrix
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, n];
        int num = 1;

        for (int depth = 0; depth < n / 2 + n % 2; depth++)
        {
            for (int col = depth; col < n - depth; col++)
            {
                matrix[depth, col] = num;
                num++;
            }

            for (int row = 1 + depth; row < n - depth; row++)
            {
                matrix[row, n - 1 - depth] = num;
                num++;
            }

            for (int col = n - 2 - depth; col >= depth; col--)
            {
                matrix[n - 1 - depth, col] = num;
                num++;
            }

            for (int row = n - 2 - depth; row > depth; row--)
            {
                matrix[row, depth] = num;
                num++;
            }
        }

        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write("{0} ", matrix[row, col]); //Console.Write("{0,4}", matrix[row, col]); --> zapazva 4 pozociiza vsqka cifra
            }
            Console.WriteLine();
        }

    }
}