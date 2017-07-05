using System;
class NotDivisibleNumbers
{
    static void Main()
    {
        uint num = uint.Parse(Console.ReadLine());

        for (int i = 1; i <= num; i++)
        {
            if ((i % 3 != 0) && (i % 7 != 0))
            {
                Console.Write(i + " ");
            }
        }
    }
}