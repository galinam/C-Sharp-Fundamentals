using System;


namespace Long_Sequence
{
    class Long_Sequence
    {
        static void Main()
        {
            for (int nextNum = 2; nextNum <= 1001; nextNum++)
            {
                if (nextNum % 2 != 0)
                {
                    Console.WriteLine(nextNum * -1);
                }
                else Console.WriteLine(nextNum);
            }
        }
    }
}
