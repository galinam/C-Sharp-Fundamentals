using System;

class MatrixOfNumbers
{
    static void Main()
    {
        byte numberN = byte.Parse(Console.ReadLine());

        byte length = numberN;

        for (byte i = 1; i <= numberN; i++)
        {

            for (byte j = i; j <= length; j++)
            {
                if (j < 10)
                {
                    //Console.Write(" ");
                    Console.Write(j + " ");
                }
                else
                {
                    Console.Write(j + " ");
                }
            }
            length += 1;
            Console.WriteLine();
        }
    }
}