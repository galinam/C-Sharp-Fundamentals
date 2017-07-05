using System;

class HexToDecimal
{
    static void Main()
    {
        string hexInput = Console.ReadLine();

        long decimalOutput = 0;
        for (int i = 0; i < hexInput.Length; i++)
        {
            int bit;
            char charOfHexInput = hexInput[i];
            switch (charOfHexInput)
            {
                case 'A': bit = 10; break;
                case 'B': bit = 11; break;
                case 'C': bit = 12; break;
                case 'D': bit = 13; break;
                case 'E': bit = 14; break;
                case 'F': bit = 15; break;
                default: bit = hexInput[i] - 48;
                    break;
            }
            decimalOutput += bit * (long)Math.Pow(16, hexInput.Length - 1 - i);
        }
        Console.WriteLine(decimalOutput);  
    }
}