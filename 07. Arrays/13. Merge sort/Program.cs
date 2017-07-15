using System;
using System.Collections.Generic;

class SortArrayWithMergeSortAlgorithm
{
    public static List<int> MergeSort(List<int> numbers)
    {
        if (numbers.Count <= 1)
        {
            return numbers;
        }

        ushort middle = (ushort)(numbers.Count / 2);
        List<int> left = new List<int>();
        List<int> right = new List<int>();
        ushort index = 0;
        for (index = 0; index < middle; index++)
        {
            left.Add(numbers[index]);
        }

        for (index = middle; index < numbers.Count; index++)
        {
            right.Add(numbers[index]);
        }

        left = MergeSort(left);
        right = MergeSort(right);

        return Merge(left, right);
    }

    public static void AppendListDuringMerge(List<int> merging, List<int> merged)
    {
        merged.Add(merging[0]);
        merging.RemoveAt(0);
    }

    public static List<int> Merge(List<int> left, List<int> right)
    {
        List<int> merged = new List<int>();
        while (left.Count > 0 || right.Count > 0)
        {
            if (left.Count > 0 && right.Count > 0)
            {
                if (left[0] <= right[0])
                {
                    AppendListDuringMerge(left, merged);
                }
                else
                {
                    AppendListDuringMerge(right, merged);
                }
            }
            else if (left.Count > 0)
            {
                AppendListDuringMerge(left, merged);
            }
            else if (right.Count > 0)
            {
                AppendListDuringMerge(right, merged);
            }
        }
        return merged;
    }

    static void Main()
    {
        // Input
        //Console.WriteLine("Enter the length of the array and its elements: ");
        int length = int.Parse(Console.ReadLine());
        List<int> numbers = new List<int>();
        for (int index = 0; index < length; index++)
        {
            numbers.Add(int.Parse(Console.ReadLine()));
        }

        // Solution
        numbers = MergeSort(numbers);

        // Printing
        for (int k = 0; k < length; k++)
        {
            Console.WriteLine(numbers[k]);
            //if (k < length)
            //{
            //    Console.Write(", ");
            //}
        }
        //Console.WriteLine();
    }
}