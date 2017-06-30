using System;
using System.Globalization;
using System.Threading;
class BiggestOf5
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture =
            CultureInfo.InvariantCulture;

        double firstNum = double.Parse(Console.ReadLine());
        double secondNum = double.Parse(Console.ReadLine());
        double thirdNum = double.Parse(Console.ReadLine());
        double fourthNum = double.Parse(Console.ReadLine());
        double fithNum = double.Parse(Console.ReadLine());

        double biggestNum = firstNum;
        
        if (biggestNum < secondNum)
        {
            biggestNum = secondNum;
        }
        if (biggestNum < thirdNum)
        {
            biggestNum = thirdNum;
        } 
        if (biggestNum < fourthNum)
        {
            biggestNum = fourthNum;
        }
        if (biggestNum < fithNum)
        {
            biggestNum = fithNum;
        }

        Console.WriteLine(biggestNum);
    }
}