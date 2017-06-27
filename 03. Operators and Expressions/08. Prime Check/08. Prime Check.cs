using System;
class Program
{  
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        bool isPrime = true;

        if (number <= 0 || number == 1)
        {
            isPrime = false;
        }
        else if (number == 2 || number == 3)
        {
            isPrime = true;
        }
        else
        {

            for (int i = 2; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    isPrime = false;
                }
            }
        }

        if (isPrime == true)
        {
            Console.WriteLine("true");
        }
        else Console.WriteLine("false");
    }
}