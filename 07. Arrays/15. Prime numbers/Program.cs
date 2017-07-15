using System;
class FindPrimeNumsSieveOfEratosthenesAlgorithm
{
    static void Main()
    {
        //int N = 10000000;
        //init our numbers array, where true denotes primality
        int numN = int.Parse(Console.ReadLine());
        bool[] isPrime = new bool[numN + 1];
        isPrime[0] = false;

        for (int k = 1; k <= numN; k++)
        {
            isPrime[k] = true;
        }

        //check every number >=2 for primality
        for (int i = 2; i <= numN; i++)
        {
            //i is prime is hasn't been "crossed off" yet
            if (isPrime[i] == true)
            {                                                                    // Ptint out prime number // it's too much to be stored in the console buffer
                                                                                 //Console.Write(i + " ");

                //"cross off" all subsequent multiples of i
                for (int j = 2 * i; j <= numN; j += i)
                {
                    isPrime[j] = false;
                }
            }
        }

        for (int i = numN; i >= 1; i--)
        {
            if (isPrime[i] == true)
            {
                Console.WriteLine(i);
                break;
            }
        }
    }
}