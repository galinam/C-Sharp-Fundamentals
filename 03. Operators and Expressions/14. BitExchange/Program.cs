using System;
class Program
{
    static void Main()
    {
        uint number = uint.Parse(Console.ReadLine());
        uint bit3, bit4, bit5, bit24, bit25, bit26;

        // take the bits
        bit3 = (number & (1 << 3)) >> 3;
        bit4 = (number & (1 << 4)) >> 4;
        bit5 = (number & (1 << 5)) >> 5;
        bit24 = (number & (1 << 24)) >> 24;
        bit25 = (number & (1 << 25)) >> 25;
        bit26 = (number & (1 << 26)) >> 26;

        uint[] bits =  {bit3, bit4, bit5, bit24, bit25, bit26 };

        // set bits on the new position

        for (int i = 0; i <= 2; i++)  // i + 24 is new position
        {
            int newPosition = i + 24;
            if (bits[i] == 0)
            {
                number = number & ~((uint)1 << newPosition);
            }
            else if (bits[i] == 1)
            {
                number = number | ((uint)1 << newPosition);
            }
        }

        for (int i = 3; i <= 5; i++) // i is new position
        {
            int newPosition = i;
            if (bits[i] == 0)
            {
                number = number & ~((uint)1 << newPosition);
            }
            else if (bits[i] == 1)
            {
                number = number | ((uint)1 << newPosition);
            }
        }
        Console.WriteLine(number);
    }
}