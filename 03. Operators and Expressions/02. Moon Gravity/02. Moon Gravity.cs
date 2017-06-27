using System;

namespace _02.Moon_Gravity
{
    class _02_Moon_Gravity
    {
        static void Main()
        {
            double weight = double.Parse(Console.ReadLine());

            double moonWeight = (weight * 17) / 100;

            Console.WriteLine("{0:F3}", moonWeight);
        }
    }
}