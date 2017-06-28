using System;
class Program
{
    static void Main()
    {
        int[] numbers = new int[5];
        int sum = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
            sum += numbers[i];
        }
        Console.WriteLine(sum);
    }
}