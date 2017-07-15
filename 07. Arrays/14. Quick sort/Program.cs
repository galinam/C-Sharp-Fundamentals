/*https://www.youtube.com/watch?v=PgBzjlCcFvc */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SortArrayWithQuickSortRecursiveAlgorithm
{

    public static int Partition(int[] array, int low, int high)
    {
        int pivot = array[high];
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (array[j] <= pivot)
            {
                i++;
                if (i != j)  //Optimization - do not swap when both pointing the same element of the array
                {
                    int temp = array[i]; // Swap
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
        }
        int swap = array[i + 1]; // Swap
        array[i + 1] = array[high];
        array[high] = swap;
        return (i + 1);
    }

    public static void QuickSort(int[] array, int low, int high)
    {
        //if (high + 1 > 10) // optimization if the partitional array is smaller than 10 elemants - implemented Selection Sort Algorithm
        //{
            if (low < high )
            {
                int pi = Partition(array, low, high);
                if ((pi - 1) > low) // check we are not outsade the array boundary and the part of array which should sort is with length more then 1
                {
                    QuickSort(array, low, pi - 1);
                }
                if ((pi + 1) < high)
                {
                     QuickSort(array, pi + 1, high);
                }
            }
        // }
        //else
        //{
        //    int temp;
        //    int min;
        //    for (int i = 0; i < array.Length - 1; i++)
        //    {
        //        min = i;

        //        for (int j = i + 1; j < array.Length; j++)
        //        {
        //            if (array[min].CompareTo(array[j]) > 0)
        //            {
        //                min = j;
        //            }
        //        }

        //        temp = array[i];
        //        array[i] = array[min];
        //        array[min] = temp;
        //    }
        //}
    }

    static void Main(string[] args)
    {
        //Input
        //IComparable[] array = { 5, 10, 8, 7, 12, 3 };
        //int length = 6;

        //Console.WriteLine("QuickSort By Recursive Method");
        //Console.WriteLine("Enter the length of the array and its elements: ");
        int length = int.Parse(Console.ReadLine());
        int[] array = new int[length];
        for (int index = 0; index < length; index++)
        {
            array[index] = int.Parse(Console.ReadLine());
        }

        // Solution
        int low = 0;
        int high = length - 1;

        QuickSort(array, low, high);

        // Printing
        foreach (var item in array)
        {
            Console.WriteLine(item);
        }
    }
}

        //    static void Main()            // Selection Sort Algorithm //
        //{
        //    // Input
        //    //Console.WriteLine("Enter the length of the array and its elements: ");
        //    int arrayLen = int.Parse(Console.ReadLine());
        //    int[] array = new int[arrayLen];
        //    for (int index = 0; index < arrayLen; index++)
        //    {
        //        array[index] = int.Parse(Console.ReadLine());
        //    }

        //    // Solution - Selection Sort Algorithm
        //    int min, temp;

        //    for (int i = 0; i < arrayLen - 1; i++)
        //    {
        //        min = i;

        //        for (int j = i + 1; j < arrayLen; j++)
        //        {
        //            if (array[min]> array[j])
        //            {
        //                min = j;
        //            }
        //        }

        //        temp = array[i];
        //        array[i] = array[min];
        //        array[min] = temp;
        //    }


        //    foreach (var item in array)
        //    {
        //        Console.WriteLine(item);
        //    }
        //}