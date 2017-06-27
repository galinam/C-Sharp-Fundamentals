using System;

namespace _01.Odd_or_Even
{
    class Program
    {
        static void Main()
        {
            short integer = short.Parse(Console.ReadLine());

            if (integer % 2 == 0)
            {
                Console.WriteLine("even {0}", integer);
            }
            else Console.WriteLine("odd {0}", integer);
        }
    }
}