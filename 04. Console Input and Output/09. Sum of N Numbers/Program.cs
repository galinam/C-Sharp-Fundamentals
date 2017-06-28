using System;
class Program
{
    static void Main()
    {
        int numN = int.Parse(Console.ReadLine());
        float[] numbers = new float[numN];
        float sum = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
            sum += numbers[i];
        }
        Console.WriteLine(sum);
    }
}
