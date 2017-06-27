using System;
class StartUp
{
    static void Main()
    {
        uint number = uint.Parse(Console.ReadLine());
        int mask = 1 << 3;

        Console.WriteLine((number & mask) >> 3);
    }
}