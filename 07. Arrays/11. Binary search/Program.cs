using System;

class BinaryСearch
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
        //Console.Write("Enter searched number: ");
        int key = int.Parse(Console.ReadLine());

        // Solution - Binary Search
        Array.Sort(array); //10   1 2 4 8 16 31 32 64 77 99   32
        int iMin = 0;
        int iMax = array.Length - 1;
        int iMid;
        bool isFound = false;

        while (iMax >= iMin)
        {
            iMid = iMin + ((iMax - iMin) / 2);
            if (array[iMid] == key)
            {
                Console.WriteLine("{0}", iMid); //The searched number is with index: 
                isFound = true;
                break;
            }
            else if (array[iMid] < key)
            {
                iMin = iMid + 1;
            }
            else
            {
                iMax = iMid - 1;
            }
        }
        if (!isFound)
        {
            Console.WriteLine("-1");
        }
    }
}