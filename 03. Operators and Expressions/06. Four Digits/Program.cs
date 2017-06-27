using System;
class Program
{
    static void Main()
    {
        int integer = int.Parse(Console.ReadLine());

        int firstDigit = integer % 10;
        int secondDigit = (integer /10) % 10;
        int thirdDigit = (integer / 100) % 10;
        int fourthDigit = (integer / 1000) % 10;

        Console.WriteLine(firstDigit + secondDigit + thirdDigit + fourthDigit);
        Console.WriteLine("{0}{1}{2}{3}", firstDigit, secondDigit, thirdDigit, fourthDigit);
        Console.WriteLine("{0}{1}{2}{3}", firstDigit, fourthDigit, thirdDigit, secondDigit);
        Console.WriteLine("{0}{1}{2}{3}", fourthDigit, secondDigit, thirdDigit, firstDigit);
    }
}