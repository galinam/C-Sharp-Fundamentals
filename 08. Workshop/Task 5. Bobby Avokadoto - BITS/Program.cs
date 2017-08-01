using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        uint maxOnesOfComb = 0;
        uint greatComb = 0;
        uint head = uint.Parse(Console.ReadLine());
        uint numOfCombs = uint.Parse(Console.ReadLine());
        //uint[] combs = new uint[numOfCombs];

        for (int i = 0; i < numOfCombs; i++)
        {
            uint comb = uint.Parse(Console.ReadLine());
            uint countOnesOfComb = 0;
            for (int j = 0; j < 32; j++)
            {
                uint bitHead = head & (uint)(1 << j);
                uint bitComb = comb & (uint)(1 << j);
                if (bitComb != 0)
                {
                    countOnesOfComb++;
                }
                if (bitHead != bitComb)
                {
                    continue;
                }
                else if ((bitHead != 0) && (bitComb != 0))
                {
                    countOnesOfComb = 0;
                    break;
                }
            }
            if (maxOnesOfComb < countOnesOfComb)
            {
                maxOnesOfComb = countOnesOfComb;
                greatComb = comb;
            }
        }
        Console.WriteLine(greatComb);

        /* Another way
        if ((head & comb) == 0)
        {
            uint countOnesOfComb = 0;
            for (int j = 0; j < 32 && ((comb >> j) > 0); j++) // or (comb >> j) != 0 ---> optimization      //while(curentComb > 0)
            {                                                                                               //{ currentCount = curentCount & 1;
                countOnesOfComb += (uint)(comb >> j) & 1; // take the bit at position j                     //  curentComb >>=1 }
            }
            if (maxOnesOfComb < countOnesOfComb)
            {
                maxOnesOfComb = countOnesOfComb;
                greatComb = comb;
            }
        }*/

    }
}