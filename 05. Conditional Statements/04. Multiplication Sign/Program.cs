using System;
using System.Threading;
using System.Globalization;

class MultiplicationSign
{
    static void Main()
    {
        //Using sequence of if statements:
        Thread.CurrentThread.CurrentCulture =
            CultureInfo.InvariantCulture;

        double firstNum = double.Parse(Console.ReadLine());
        double secondNum = double.Parse(Console.ReadLine());
        double thirdNum = double.Parse(Console.ReadLine());

        int negativeNumberCount = 0;

        if (firstNum == 0 || secondNum == 0 || thirdNum == 0)
        {
            Console.WriteLine(0);
        }

        if (firstNum < 0 && firstNum != 0)
        {
            negativeNumberCount++;
        }
        if (secondNum < 0 && secondNum != 0)
        {
            negativeNumberCount++;
        }
        if (thirdNum < 0 && thirdNum != 0)
        {
            negativeNumberCount++;
        }
        if (negativeNumberCount % 2 == 0 && (firstNum != 0 && secondNum != 0 && thirdNum != 0))
        {
            Console.WriteLine("+");
        }
        if (negativeNumberCount % 2 != 0 && (firstNum != 0 && secondNum != 0 && thirdNum != 0))
        {
            Console.WriteLine("-");
        }


        //This way is easier but is with nested if statement:
        // Thread.CurrentThread.CurrentCulture =
        //    CultureInfo.InvariantCulture;

        //double firstNum = double.Parse(Console.ReadLine());
        //double secondNum = double.Parse(Console.ReadLine());
        //double thirdNum = double.Parse(Console.ReadLine());

        //int negativeNumberCount = 0;

        //if (firstNum == 0 || secondNum == 0 || thirdNum == 0)
        //{
        //    Console.WriteLine("0");
        //}
        //else
        //{
        //    if (firstNum < 0)
        //    {
        //        negativeNumberCount++;
        //    }
        //    if (secondNum < 0)
        //    {
        //        negativeNumberCount++;
        //    }
        //    if (thirdNum < 0)
        //    {
        //        negativeNumberCount++;
        //    }
        //    if (negativeNumberCount %2 == 0)
        //    {
        //        Console.WriteLine("+");
        //    }
        //    else Console.WriteLine("-");
        // }
    }
}