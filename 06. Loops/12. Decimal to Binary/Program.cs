using System;

class DecimalToBinary
{
    static void Main()
    {
        long decimalInput = long.Parse(Console.ReadLine());

        string binaryOutput = "";
        while (decimalInput != 0)
        {
            binaryOutput += decimalInput % 2;
            decimalInput /= 2;
        }

        char[] result = binaryOutput.ToCharArray();
        Array.Reverse(result);
        Console.WriteLine(new string(result));
    }
}