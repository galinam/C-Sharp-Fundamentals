using System;

class Program
{
    static void Main()
    {
        double coordX = double.Parse(Console.ReadLine());
        double coordY = double.Parse(Console.ReadLine());
        double distance;

        distance = Math.Sqrt((coordX - 1) * (coordX - 1) + (coordY -1) * (coordY -1));

        if (Math.Abs(distance) <= 1.5)
        {
            Console.Write("inside circle ");
        }
        else Console.Write("outside circle ");

        if ((5 >= coordX && coordX >= -1) && (-1 <= coordY && coordY <= 1))
        {
            Console.WriteLine("inside rectangle");
        }
        else Console.WriteLine("outside rectangle");
    }
}