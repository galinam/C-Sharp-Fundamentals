using System;
using System.Numerics;

class GCD
{
    static void Main()
    {
        string input = Console.ReadLine();

        char delimiterChar = ' ';
        string[] numbers = input.Split(delimiterChar);

        BigInteger firstNum = Convert.ToInt32(numbers[0]);
        BigInteger secondNum = Convert.ToInt32(numbers[1]);
        if (firstNum < secondNum)
        {
            BigInteger temp = firstNum;
            firstNum = secondNum;
            secondNum = temp;
        }

        BigInteger divisor;
        BigInteger residue = firstNum % secondNum;
        do
        {
            divisor = residue;
            residue = secondNum % residue;
            secondNum = divisor;
        }
        while (residue != 0);

        Console.WriteLine(divisor);
    }
}