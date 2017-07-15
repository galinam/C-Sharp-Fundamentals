using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class RemoveElemntsFromArray // This implementation is not working correctly.
{
    static void Main()
    {
        //Input
        int length = int.Parse(Console.ReadLine());
        List<int> array = new List<int>(length);
        for (int i = 0; i < length; i++)
        {
            array.Add(int.Parse(Console.ReadLine()));
        }
        List<int> arrConflicts = new List<int>(length);
        bool isArraySorted = true;
        int countConflicts = 0;
        int maxConflicts = 0;
        int index = 0;
        int countRemovedElement = 0;

        //Solution
        //Step1: find how many conflicts has any element of the array
        for (int i = 0; i < array.Count; i++)
        {
            int currentElement = array[i];

            for (int j = i + 1; j < array.Count; j++)
            {
                if (currentElement > array[j])
                {
                    countConflicts++;
                }
            }

            for (int k = i - 1; k >= 0; k--)
            {
                if (currentElement < array[k])
                {
                    countConflicts++;
                }
            }

            arrConflicts.Add(countConflicts);
            countConflicts = 0;
        }

        do
        {
            //Step2: Check if the array is sorrted
            for (int i = 0; i < array.Count - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    isArraySorted = false;
                    break;
                }
                else isArraySorted = true;
            }

            if (isArraySorted == false)
            {
                //Step3: Find the maxConflicts in arrConflicts and remove the element with max conflicts from array.
                maxConflicts = 0;
                for (int i = 0; i < arrConflicts.Count; i++)
                {
                    if (arrConflicts[i] > maxConflicts)
                    {
                        maxConflicts = arrConflicts[i];
                        index = i;
                    }
                }

                //Step3: If not sorted, remove the next elemenen with max conflicts, count the removable elements
                if (array.Count > 0)
                {
                    array.RemoveAt(index);
                    countRemovedElement++;
                    arrConflicts.RemoveAt(index);
                }
                else
                {
                    countRemovedElement = length - 1;
                    break;
                }
            }
        } while (isArraySorted == false);

        //Output
        Console.WriteLine(countRemovedElement);
    }
}

