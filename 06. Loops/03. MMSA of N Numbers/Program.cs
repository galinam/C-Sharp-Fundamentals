using System;
using System.Globalization;
using System.Threading;
class MMSAofNnumbers
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture =
          CultureInfo.InvariantCulture;

        int numN = int.Parse(Console.ReadLine());
        double[] numbers = new double[numN];
        double minN = 10000;
        double maxN = -10000;
        double sum = 0;
        double avg = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = double.Parse(Console.ReadLine());
            if (minN > numbers[i])
            {
                minN = numbers[i];
            }
            if (maxN < numbers[i])
            {
                maxN = numbers[i];
            }
            sum += numbers[i];
        }
        avg = sum / numN;
        Console.WriteLine("min={0:0.00}\nmax={1:0.00}\nsum={2:0.00}\navg={3:0.00} ", minN, maxN, sum, avg);
    }
}