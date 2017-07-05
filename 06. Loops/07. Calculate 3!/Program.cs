using System;
using System.Numerics;

class Calculate3
{
    static void Main()
    {
        int numN = int.Parse(Console.ReadLine());
        int numK = int.Parse(Console.ReadLine());
        BigInteger factorielN = 1;
        BigInteger factorielK = 1;
        BigInteger factorielM = 1;
        int numM = numN - numK;

        for (int i = 1, j = 1; i <= numN; i++, j++)
        {
            factorielN *= i;
            if (j <= numK)
            {
                factorielK *= j;
            }
        }
        for (int i = 1; i <= numM; i++)
        {
            factorielM *= i;
        }
        BigInteger result;
        result = factorielN / (factorielK * factorielM);
        Console.WriteLine(result);
    }
}