using System;
using System.Threading;
using System.Globalization;
using System.Collections.Generic;

class BiggestOfThree
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture =
            CultureInfo.InvariantCulture;

        double firstNum = double.Parse(Console.ReadLine());
        double secondNum = double.Parse(Console.ReadLine());
        double thirdNum = double.Parse(Console.ReadLine());

        double biggestNum = firstNum;

        if (biggestNum < secondNum)
        {
            biggestNum = secondNum;
        }
        if (biggestNum < thirdNum)
        {
            biggestNum = thirdNum;
        }

        Console.WriteLine(biggestNum);

       
    }
}