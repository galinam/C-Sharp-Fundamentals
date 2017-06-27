using System;

class Program
{
    static void Main()
    {
        double coordX = double.Parse(Console.ReadLine());
        double coordY = double.Parse(Console.ReadLine());
        double distance;

        distance = Math.Sqrt(coordX * coordX + coordY * coordY);

        if (Math.Abs(distance) <= 2)
        {
            Console.WriteLine("yes {0:F2}", distance);
        }
        else Console.WriteLine("no {0:F2}", distance);
    }
}