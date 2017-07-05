using System;
using System.Numerics;
class CalculateAgain
{
    static void Main()
    {
        int numN = int.Parse(Console.ReadLine());
        int numK = int.Parse(Console.ReadLine());

        BigInteger factorielN = 1;
        BigInteger factorielK = 1;
        for (int i = 1, j = 1; i <= numN; i++, j++)
        {
            factorielN *= i;
            if (j <= numK)
            {
                factorielK *= j;
            }
        }

        BigInteger result;
        result = factorielN / factorielK;
        Console.WriteLine(result);
    }
}