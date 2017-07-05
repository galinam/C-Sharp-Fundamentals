using System;
class OddAndEvenProduct
{
    static void Main()
    {
        int nElements = int.Parse(Console.ReadLine());
        string input = Console.ReadLine();

        char delimiterChar = ' ';
        string[] numbers = input.Split(delimiterChar);

        long oddProduct = 1;
        long evenProduct = 1;
        for (int i = 0; i < nElements; i++)
        {
            if (i % 2 == 0)
            {
                evenProduct *= Convert.ToInt32(numbers[i]);
            }
            else
            {
                oddProduct *= Convert.ToInt32(numbers[i]);
            }
        }

        if (evenProduct == oddProduct)
        {
            Console.WriteLine("yes {0}", evenProduct);
        }
        else
        {
            Console.WriteLine("no {0} {1}", evenProduct, oddProduct);
        }
    }
}