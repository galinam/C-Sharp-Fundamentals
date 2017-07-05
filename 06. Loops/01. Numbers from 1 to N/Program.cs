using System;
class NumbersFrom1toN
{
    static void Main()
    {
        uint num = uint.Parse(Console.ReadLine());

        for (int i = 1; i <= num; i++)
        {
            Console.Write(i + " ");
        }
    }
}