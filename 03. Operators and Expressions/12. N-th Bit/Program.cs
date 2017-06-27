using System;
class Program
{
    static void Main()
    {
        uint numberP = uint.Parse(Console.ReadLine());
        int bitN = int.Parse(Console.ReadLine());
        int mask = 1 << bitN;

        Console.WriteLine((numberP & mask) >> bitN);

    }
}