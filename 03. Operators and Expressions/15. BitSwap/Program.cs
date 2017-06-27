using System;
class Program
{
    static void Main()
    {
        uint number = uint.Parse(Console.ReadLine());
        int bitP = int.Parse(Console.ReadLine());
        int bitQ = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        uint[] pBits = new uint[k];
        uint[] qBits = new uint[k];

        // take the bits

        for (int i = 0; i < pBits.Length; i++)
        {
            pBits[i] = (number & ((uint)1 << (bitP + i))) >> (bitP + i);
        }
        for (int i = 0; i < qBits.Length; i++)
        {
            qBits[i] = (number & ((uint)1 << (bitQ + i))) >> (bitQ + i);
        }



        // set bits on the new position

        for (int i = 0; i < k; i++)  
        {
            int newPosition = i + bitQ;
            if (pBits[i] == 0)
            {
                number = number & ~((uint)1 << newPosition);
            }
            else if (pBits[i] == 1)
            {
                number = number | ((uint)1 << newPosition);
            }
        }

        for (int i = 0; i < k; i++) 
        {
            int newPosition = i +bitP;
            if (qBits[i] == 0)
            {
                number = number & ~((uint)1 << newPosition);
            }
            else if (qBits[i] == 1)
            {
                number = number | ((uint)1 << newPosition);
            }
        }
        Console.WriteLine(number);
    }
}