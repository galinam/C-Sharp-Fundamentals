using System;

class ExchangeIfGreater
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());

        if (a > b)
        {
            double store;
            store = a;
            a = b;
            b = store;
        }

        Console.WriteLine(a + " " + b);
    }
}