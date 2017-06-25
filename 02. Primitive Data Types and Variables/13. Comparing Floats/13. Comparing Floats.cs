using System;
using System.Globalization;
using System.Threading;

namespace _13.Comparing_Floats
{
    class _13_Comparing_Floats
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            double firstNum = double.Parse(Console.ReadLine());
            double secondNum = double.Parse(Console.ReadLine());

            double percision = 0.000001; //eps.
            double diff = firstNum - secondNum;

            if (diff < 0)
            {
                diff *= -1;
            }

            if (diff >= percision)
            {
                Console.WriteLine("false");
            }
            else if (diff < percision)
            {
                Console.WriteLine("true");
            }
        }
    }
}
