using System;

class Program
{
    static void Main()
    {
        double sideA = double.Parse(Console.ReadLine());
        double sideB = double.Parse(Console.ReadLine());
        double hieghtH = double.Parse(Console.ReadLine());
        double trapezoidArea;

        trapezoidArea = ((sideA + sideB) / 2) * hieghtH;

        Console.WriteLine("{0:F7}", trapezoidArea);
    }
}