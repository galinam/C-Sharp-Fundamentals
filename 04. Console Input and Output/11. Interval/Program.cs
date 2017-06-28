using System;

class Program
{
    static void Main()
    {
        int numN = int.Parse(Console.ReadLine());
        int numM = int.Parse(Console.ReadLine());
        int counter = 0;
        
        for (int i = numN + 1; i < numM; i++)
        {
            if (i % 5 == 0)
            {
                counter++;
            }
        }
        Console.WriteLine(counter);
    }
}