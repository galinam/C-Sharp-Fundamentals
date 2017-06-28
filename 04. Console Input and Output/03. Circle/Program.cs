using System;
using System.Threading;
using System.Globalization;

class Circle
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture =
            CultureInfo.InvariantCulture;

        double radiusR = double.Parse(Console.ReadLine());

        double perimeterP = 2 * Math.PI * radiusR;
        Console.Write("{0:0.00} ", perimeterP);

        double areaS = Math.PI * radiusR * radiusR;
        Console.WriteLine("{0:F2}", areaS);
    }
}