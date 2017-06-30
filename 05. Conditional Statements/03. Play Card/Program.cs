using System;
using System.Globalization;
using System.Threading;

class PlayCard
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture =
            CultureInfo.InvariantCulture;

        string inputStr = Console.ReadLine();
        
        switch (inputStr)
        {
            case "2":
            case "3":
            case "4":
            case "5":
            case "6":
            case "7":
            case "8":
            case "9":
            case "10":
            case "J":
            case "Q":
            case "K":
            case "A":
                Console.WriteLine("yes {0}", inputStr); break;
            default: Console.WriteLine("no {0}", inputStr);
                break;
        }
    }
}