using System;

class MaximalIncreasingSequence
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

        // Solution
        int start = 0;
        int length = 0;
        int bestStart = 0;
        int bestLength = 1;
        int previousElement = array[0];
        for (int index = 0; index < array.Length; index++)
        {
            if (array[index] > previousElement)
            {
                length++;
            }
            else 
            {
                start = index;
                length = 1;
            }
            if (bestLength < length)
            {
                bestLength = length;
                bestStart = start;
            }
            previousElement = array[index];
        }

        // Printing
        //Console.WriteLine("The maximal increasing sequence in the array is: ");
        //for (int i = bestStart; i < bestStart + bestLength; i++)
        //{
        //    Console.Write(array[i]);
        //    if (i < bestStart + bestLength - 1)
        //    {
        //        Console.Write(", ");
        //    }
        //}
        //Console.WriteLine();
        Console.WriteLine(bestLength);
    }
}