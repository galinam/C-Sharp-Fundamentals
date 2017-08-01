using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        char symbol = char.Parse(Console.ReadLine());

        for (int i = 0; i < size / 2; i++)
        {
            Console.Write(new string(' ', i));
            Console.Write(new string(symbol, size - i));
            if (i < (size / 2) - 1)
            {
                Console.Write(new string(' ', size));
            }
            else
            {
                Console.Write(new string(' ', (size - 3) / 2));
                Console.Write(symbol);
                Console.Write(' ');
                Console.Write(symbol);
                Console.Write(new string(' ', (size - 3) / 2));
            }
            Console.WriteLine(new string(symbol, size - i));
        }

        for (int i = 0; i < size / 3; i++)
        {
            int m = (((size / 2) + 1) * 2) + size;
            Console.Write(new string(' ', size / 2));
            Console.WriteLine(new string(symbol, m));
        }

        for (int i = 1; i <= size / 2; i++)
        {
            Console.Write(new string(' ', size + i));
            Console.WriteLine(new string(symbol, size - (i * 2)));
        }
    }
}