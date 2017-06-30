using System;
using System.Threading;
using System.Globalization;


class SortThreeRealNumbersDescending
{
    static void Main()
    {
        //Using nested if statements:
        Thread.CurrentThread.CurrentCulture =
            CultureInfo.InvariantCulture;


        double firstNum = double.Parse(Console.ReadLine());
        double secondNum = double.Parse(Console.ReadLine());
        double thirdNum = double.Parse(Console.ReadLine());

        double tempNum;

        if (firstNum <= secondNum && secondNum <= thirdNum)
        {
            Console.WriteLine(thirdNum + " " + secondNum + " " + firstNum);
        }
        else if (firstNum <= thirdNum && thirdNum <= secondNum)
        {
            tempNum = secondNum;
            secondNum = thirdNum;
            thirdNum = tempNum;
            Console.WriteLine(thirdNum + " " + secondNum + " " + firstNum);
        }
        else if (secondNum <= firstNum && firstNum <= thirdNum)
        {
            tempNum = firstNum;
            firstNum = secondNum;
            secondNum = tempNum;
            Console.WriteLine(thirdNum + " " + secondNum + " " + firstNum);
        }
        else if (secondNum <= thirdNum && thirdNum <= firstNum)
        {
            tempNum = secondNum;
            secondNum = thirdNum;
            thirdNum = tempNum;
            Console.WriteLine(firstNum + " " + secondNum + " " + thirdNum);
        }
        else if (thirdNum <= firstNum && firstNum <= secondNum)
        {
            tempNum = firstNum;
            firstNum = secondNum;
            secondNum = tempNum;
            Console.WriteLine(firstNum + " " + secondNum + " " + thirdNum);
        }
        else if (thirdNum <= secondNum && secondNum <= firstNum)
        {
            Console.WriteLine(firstNum + " " + secondNum + " " + thirdNum);
        }
    }
}