using System;
class Program
{
    static void Main()
    {
        ulong numberN = ulong.Parse(Console.ReadLine());
        int position = int.Parse(Console.ReadLine());
        int bitValue = int.Parse(Console.ReadLine());
        
        if (bitValue == 0)
        {
            Console.WriteLine(numberN & ~((ulong)1 << position));
        }

        else if (bitValue == 1)
        {
            Console.WriteLine(numberN | ((ulong)1 << position));
        }
        
    }
}