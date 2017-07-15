using System;
using System.Collections.Generic;

class AllocateArray
{
    static void Main()
    {
        //int numN = int.Parse(Console.ReadLine());
        //int[] arr = new int[numN];

        //for (int i = 0; i < numN; i++)
        //{
        //    arr[i] = i * 5;
        //    Console.WriteLine(arr[i]);
        //}


        int length = int.Parse(Console.ReadLine());
        List<int> array = new List<int>(length);
        for (int i = 0; i < length; i++)
        {
            array.Add(int.Parse(Console.ReadLine()));
        }
        List<int> arrConflicts = new List<int>(length);
        bool isArraySorted = true;
        int countConflicts = 0;
        int maxConflicts = 0;
        int index = 0;
        int countRemovedElement = 0;

        //Solution
        //Step1: find how many conflicts has any element of the array
        for (int i = 0; i < array.Count; i++)
        {
            int currentElement = array[i];

            for (int j = i + 1; j < array.Count; j++)
            {
                if (currentElement > array[j])
                {
                    countConflicts++;
                }
            }

            for (int k = i - 1; k > 0; k--)
            {
                if (currentElement < array[k])
                {
                    countConflicts++;
                }
            }

            arrConflicts.Add(countConflicts);
            countConflicts = 0;
        }
        foreach (var item in arrConflicts)
        {
            Console.WriteLine(item);
        }
    }
}