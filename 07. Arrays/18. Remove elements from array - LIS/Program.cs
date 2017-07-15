/*Longest Increasing Sequence - https://www.youtube.com/watch?v=Ns4LCeeOFS4 */
using System;
using System.Collections.Generic;
using System.Linq;
class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[] numbers = new int[n];
        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        int[] longestIncreasingSequence = new int[n];
        for (int i = 0; i < n; i++)
        {
            longestIncreasingSequence[i] = 1;
        }

        for (int i = 1; i < n; i++)
        {
            for (int j = 0; j < i; j++)
            {
                if (numbers[j] <= numbers[i])
                {
                    longestIncreasingSequence[i] = Math.Max(longestIncreasingSequence[i], longestIncreasingSequence[j] + 1);
                }
            }
        }

        Console.WriteLine(n - longestIncreasingSequence.Max());
    }

    /*
     *  int n = int.Parse(Console.ReadLine());
        List<int> numbers = new List<int>();
 
        AddNumbersToList(n, numbers);
        int[] size = new int[numbers.Count];
       
        // Define each number as subsequence.
        for (int i = 0; i < numbers.Count; i++)
        {
            size[i] = 1;
        }
 
        int max = 1;
        // Compare current number with the numbers before.
        for (int i = 1; i < numbers.Count; i++)
        {
            for (int j = 0; j < i; j++)
            {
                if (numbers[i] >= numbers[j] && size[i] <= size[j] + 1)
                {
                    size[i] = size[j] + 1;
                    // Update max increasing subsequence.
                    if (max < size[i])
                    {
                        max = size[i];
                    }
                }
            }
        }
 
        // Print numbers to remove as a result.
        int numbersToRemove = n - max;
        Console.WriteLine(numbersToRemove);
    }
 
    private static void AddNumbersToList(int n, List<int> numbers)
    {
        for (int i = 0; i < n; i++)
        {
            int currentNumber = int.Parse(Console.ReadLine());
            numbers.Add(currentNumber);
        }
     */
}