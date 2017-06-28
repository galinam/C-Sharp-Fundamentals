using System;

class FibonacciMembers
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int counter = 1;
        decimal lastFiN = 0;
        decimal nextFiN = 1;

        Console.Write(0 + ", ");
        Console.Write(1 + ", ");

        while (counter < n - 1)
        {
            counter++;
            nextFiN += lastFiN;
            lastFiN = nextFiN - lastFiN;
            Console.Write(nextFiN);
            if (counter != n - 1)
            {
                Console.Write(", ");
            }
        }
    }
}