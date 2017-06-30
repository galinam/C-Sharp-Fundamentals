using System;
using System.Threading;
using System.Globalization;


class IntDoubleString
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture =
            CultureInfo.InvariantCulture;
                
        string choice = Console.ReadLine();

        switch (choice)
        {
            case "integer": 
                int intNum = int.Parse(Console.ReadLine());
                Console.WriteLine(++intNum);
                break;
            case "real": 
                double doubleNum = double.Parse(Console.ReadLine());
                Console.WriteLine("{0:0.00}",++doubleNum);
                break;
            case "text": 
                string stringNum = (Console.ReadLine());
                Console.WriteLine("{0}*", stringNum);
                break;
            default: 
                break;
        }
    }
}