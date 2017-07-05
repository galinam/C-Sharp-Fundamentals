using System;
using System.Numerics;

class Trailing0inNfactorial
{
    static void Main()
    {
        BigInteger numberN = BigInteger.Parse(Console.ReadLine());
        BigInteger diviser = 5;
        BigInteger sum = 0;
        while (diviser <= numberN)
        {
            sum += numberN / diviser;
            diviser *= 5;
        }
        Console.WriteLine(sum);

        /* We could easy check the result:
        BigInteger factorialN = 1;
        for (int i = 1; i <= numberN; i++)
        {
            factorialN *= i;
        }
        Console.WriteLine(factorialN);
        */
    }
}