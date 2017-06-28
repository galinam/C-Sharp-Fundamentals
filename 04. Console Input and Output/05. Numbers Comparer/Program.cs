using System;
class Program
{
    static void Main()
    {
        float firstNum = float.Parse(Console.ReadLine());

        float secondNum = float.Parse(Console.ReadLine());

        float greaterNum = firstNum > secondNum ? firstNum : secondNum;

        Console.WriteLine(greaterNum);
    }
}