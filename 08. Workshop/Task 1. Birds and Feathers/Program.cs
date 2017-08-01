using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Globalization;
using System.Threading;

class Program
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        int birds = int.Parse(Console.ReadLine());
        BigInteger feathers = BigInteger.Parse(Console.ReadLine());
        double average;
        double result;

        if (birds == 0 && feathers == 0)
        {
            Console.WriteLine("0.0000");
        }
        else
        {
            average = (double)feathers / birds;

            if (birds % 2 == 0)
            {
                result = average * 123123123123;
            }
            else
            {
                result = average / 317;
            }

            Console.WriteLine("{0:f4}", result);
        }
    }
}