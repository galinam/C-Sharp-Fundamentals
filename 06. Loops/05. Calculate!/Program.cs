using System;

class Calculata
{
    static void Main()
    {
        int numN = int.Parse(Console.ReadLine());
        double numX = double.Parse(Console.ReadLine());

        double factoriel = 1;
        double power = 1;
        double sum = 1;

        for (int i = 1; i <= numN; i++)
        {
            factoriel *= i;
            power *= numX;
            sum += factoriel / power;
        }
        Console.WriteLine("{0:F5}", sum);
    }
}