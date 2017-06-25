using System;

namespace _14.Print_the_ASCII_Table
{
    class Program
    {
        static void Main()
        {
            for (int counter = 33; counter < 127; counter++)
            {
                Console.Write((char)counter);
            }
        }
    }
}
