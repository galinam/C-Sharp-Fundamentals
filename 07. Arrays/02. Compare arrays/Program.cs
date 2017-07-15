using System;

class CompareArrays
{
    static void Main()
    {
        int numN = int.Parse(Console.ReadLine());
        int[] arr1 = new int[numN];
        int[] arr2 = new int[numN];
        bool isEqual = true;

        for (int i = 0; i < numN; i++)
        {
            arr1[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < numN; i++)
        {
            arr2[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < numN; i++)
        {
            if (arr1[i] != arr2[i])
            {
                isEqual = false;
                break;
            }
        }

        if (isEqual == true)
        {
            Console.WriteLine("Equal");
        }
        else Console.WriteLine("Not equal");
    }
}