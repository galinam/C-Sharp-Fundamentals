using System;
class Program
{
    static void Main()
    {
        int numberN = int.Parse(Console.ReadLine());
        int thirdDigit = (numberN / 100) % 10;

        if (thirdDigit == 7)
        {
            Console.WriteLine("true");
        }
        else Console.WriteLine("false {0}", thirdDigit);
    }
}