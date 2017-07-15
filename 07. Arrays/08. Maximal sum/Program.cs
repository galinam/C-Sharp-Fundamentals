using System;

class MaximalSum
{
    static void Main()
    {
        // Input
        //Console.WriteLine("Enter the length of the array and its elements: ");
        int arrayLength = int.Parse(Console.ReadLine());
        int[] array = new int[arrayLength];
        for (int index = 0; index < array.Length; index++)
        {
            array[index] = int.Parse(Console.ReadLine());
        }

        //int[] array = new int[] { 2, 3, -6, -1, 2, -1, 6, 4, -8, 8 };

        // Solution - Kadane's Algorithm
        int currentSum = array[0];
        int maxSum = array[0];
        int begin = 0;
        int beginTemp = 0;
        int end = 0;
        for (int i = 1; i < array.Length; i++)
        {            
            if (currentSum < 0)
            {
                currentSum = array[i];
                beginTemp = i;
            }
            else 
            {
                currentSum += array[i];
            }
            if (currentSum > maxSum)
            {
                maxSum = currentSum;
                begin = beginTemp;
                end = i;
            }
        }

        // Printing
        //for (int j = begin; j <= end; j++)
        //{
        //    Console.Write(array[j]);
        //    if (j < end)
        //    {
        //        Console.Write(", ");
        //    }
        //}
        //Console.WriteLine();
        Console.WriteLine(maxSum);
    }
}