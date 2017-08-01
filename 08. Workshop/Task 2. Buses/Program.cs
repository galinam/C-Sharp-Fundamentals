using System;

class Program
{
    static void Main()
    {
        int buses = int.Parse(Console.ReadLine());
        int[] busesSpeed = new int[buses];
        for (int i = 0; i < buses; i++)
        {
            busesSpeed[i] = int.Parse(Console.ReadLine());
        }
        int countBusesGroup = 1;

        int firstBussInGroup = busesSpeed[0];
        for (int i = 1; i < busesSpeed.Length; i++)
        {
                            
                if (firstBussInGroup >= busesSpeed[i])
                {
                    countBusesGroup++;
                    firstBussInGroup = busesSpeed[i];
                }            
        }

        Console.WriteLine(countBusesGroup);
    }
}