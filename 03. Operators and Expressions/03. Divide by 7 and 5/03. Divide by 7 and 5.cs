﻿using System;

namespace _03.Divide_by_7_and_5
{
    class _03_Divide_by_7_and_5
    {
        static void Main()
        {
            int number = int.Parse(Console.ReadLine());

            if ((number % 7 == 0) && (number % 5 ==0))
            {
                Console.WriteLine("true {0}", number);
            }
            else Console.WriteLine("false {0}", number);
        }
    }
}