using System;

class Program
{
    static void Main()
    {
        int totalDigits = int.Parse(Console.ReadLine());
        int countDigits = 1;

        for (int page = 2; page < 1000000; page++)
        {
            char[] pageDigits = page.ToString().ToCharArray();
            countDigits += pageDigits.Length;

            if (countDigits == totalDigits)
            {
                Console.WriteLine(page);
                break;
            }
        }        
    }
}