using System;

class FrequentNumber
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

        // Solution 
        Array.Sort(array); // {-8, -6, -1, -1, 2, 2, 3, 4, 6, 8}
        int currentNum;
        int mostFreqNum = array[0];
        int count = 1;
        
        for (int i = 0; i < array.Length; i++)
        {
            int countTemp = 1;
            currentNum = array[i];
            for (int j = 1; j < array.Length; j++)
            {
                if (currentNum == array[j])
                {
                    countTemp++;
                }
                else
                {
                    currentNum = array[j];
                    countTemp = 1;
                }
                if (countTemp >= count)
                {
                    mostFreqNum = currentNum;
                    count = countTemp;
                }
            }

        }

        // Printing  
        //Console.WriteLine(string.Join(", ", array));
        if (count==1)
        {
            Console.WriteLine("{0} ({1} time)", mostFreqNum, count);
        }
        else Console.WriteLine("{0} ({1} times)", mostFreqNum, count);
    }
}