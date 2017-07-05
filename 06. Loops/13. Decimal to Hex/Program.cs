using System;

class DecimalToHex
{
    static void Main()
    {
        long decimalInput = long.Parse(Console.ReadLine());

        string hexOutput = "";

        while (decimalInput != 0)
        {
            long residue = decimalInput % 16;
            switch (residue)
            {
                case 10: hexOutput += "A"; break;
                case 11: hexOutput += "B"; break;
                case 12: hexOutput += "C"; break;
                case 13: hexOutput += "D"; break;
                case 14: hexOutput += "E"; break;
                case 15: hexOutput += "F"; break;
                default: hexOutput += residue;
                    break;
            }

            decimalInput /= 16;
        }

        char[] result = hexOutput.ToCharArray();
        Array.Reverse(result);
        Console.WriteLine(new string(result));
    }
}