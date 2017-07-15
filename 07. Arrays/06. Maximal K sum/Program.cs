using System;

class MaximalKsum
{
    static void Main()
    {
        // Input 
        int numN = int.Parse(Console.ReadLine());
        int numK = int.Parse(Console.ReadLine());
        int[] array = new int[numN];
       
        for (int index = 0; index < numN; index++)
        {
            array[index] = int.Parse(Console.ReadLine());
        }

        // Solution
        int sum = 0;
        int temp = array[0];
        for (int i = 0; i < numN; i++)
        {
            for (int j = i + 1; j < numN; j++)
            {
                if (array[i] > array[j])
                {
                    temp = array[i];
                    array[i] = array[j];
                    array[j] = temp;
                }
            }
        }
            
        for (int i = numK; i >= 1; i--)
        {
            //Console.Write(array[numN - i]);
            //if (i > 1)
            //{
            //    Console.Write(", ");
            //}
            sum += array[numN - i];
        }
        Console.WriteLine(sum);
    }
}