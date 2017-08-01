using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main()
    {
        uint head = uint.Parse(Console.ReadLine());
        uint numOfCombs = uint.Parse(Console.ReadLine());
        uint[] combs = new uint[numOfCombs];

        int maxOnesOfComb = 0;
        uint greatComb = 0;
        string strHead = Convert.ToString(head, 2).PadLeft(32);
        for (int i = 0; i < numOfCombs; i++)
        {
            combs[i] = uint.Parse(Console.ReadLine());
            string currentComb = Convert.ToString(combs[i], 2).PadLeft(32);
            int countOnesOfComb = 0;

            for (int j = currentComb.Length - 1; j >= 0; j--)
            {
                if (currentComb[j] == '1')
                {
                    countOnesOfComb++;
                }
                if (strHead[j] != currentComb[j])
                {
                    continue;
                }
                else if (strHead[j] == '1' && currentComb[j] == '1')
                {
                    countOnesOfComb = 0;
                    break;
                }
                else if (strHead[j] == ' ' || ' ' == currentComb[j])
                {
                    break;
                }
            }
            if (maxOnesOfComb < countOnesOfComb)
            {
                maxOnesOfComb = countOnesOfComb;
                greatComb = combs[i];
            }
        }

        Console.WriteLine(greatComb);
    }
}