using System;

class SelectionSort
{
    static void Main()
    {
        // Input
        //Console.WriteLine("Enter the length of the array and its elements: ");
        int arrayLen = int.Parse(Console.ReadLine());
        int[] array = new int[arrayLen];
        for (int index = 0; index < arrayLen; index++)
        {
            array[index] = int.Parse(Console.ReadLine());
        }

        // Solution - Selection Sort Algorithm
        int min, temp;

        for (int i = 0; i < arrayLen - 1; i++)
        {
            min = i;

            for (int j = i + 1; j < arrayLen; j++)
            {
                if (array[min] > array[j])
                {
                    min = j;
                }
            }

            temp = array[i];
            array[i] = array[min];
            array[min] = temp;
        }

        // Printing
        //Console.WriteLine(string.Join(", ", array));
        for (int i = 0; i < arrayLen; i++)
        {
            Console.WriteLine(array[i]);
        }
    }
}