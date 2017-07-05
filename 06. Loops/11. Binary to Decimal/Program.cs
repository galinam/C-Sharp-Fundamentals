using System;

class BinaryToDecimal
{
    static void Main()
    {
        string binaryInput = Console.ReadLine();
        long decimalOutput = 0;

        char[] bits = binaryInput.ToCharArray();

        for (int i = 0; i < bits.Length; i++)
        {
            int bit = Convert.ToInt32(bits[i]) - 48;
            decimalOutput += bit * (long)Math.Pow(2, bits.Length - 1 - i);
        }

        Console.WriteLine(decimalOutput);

    }
}