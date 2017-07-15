//using System;

//class CompareCharArrays
//{
//    static void Main()
//    {
        //string str1 = Console.ReadLine();
        //string str2 = Console.ReadLine();
        //bool equals = true;

        //char[] charArr1 = str1.ToCharArray();
        //char[] charArr2 = str2.ToCharArray();

        //int length = Math.Min(str1.Length, str2.Length);
                
        //for (int i = 0; i < length; i++)
        //{
        //    int ch1 = Convert.ToInt32(charArr1[i]);
        //    int ch2 = Convert.ToInt32(charArr2[i]);       
        //    if (ch1 != ch2)
        //    {
        //        equals = false; ///// Bad idea, missing cases!
        //    }
        //    if (ch1 < ch2)
        //    {
        //        Console.WriteLine("<");
        //        break;
        //    }
        //    if (ch1 > ch2)
        //    {
        //        Console.WriteLine(">");
        //        break;
        //    }
        //}


        //if (equals == true)
        //{
        //    Console.WriteLine("=");
        //}  
//    }
//}

using System;

class ComparesCharArrays
{
    static void Main()
    {
        // Input
        char[] firstCharArray = Console.ReadLine().ToCharArray();
        //Console.WriteLine(new string(firstCharArray));

        char[] secondCharArray = Console.ReadLine().ToCharArray();
        //Console.WriteLine(new string(secondCharArray));

        // Solution
        if (firstCharArray.Length < secondCharArray.Length)
        {
            for (int index = 0; index < firstCharArray.Length; index++)
            {
                if (firstCharArray[index] == secondCharArray[index])
                {
                    if (index == firstCharArray.Length - 1)
                    {
                        Console.WriteLine("<");
                    }
                    continue;
                }
                else if (firstCharArray[index] < secondCharArray[index])
                {
                    Console.WriteLine("<");
                    break;
                }
                else if (firstCharArray[index] > secondCharArray[index])
                {
                    Console.WriteLine(">");
                    break;
                }
            }
        }

        else if (firstCharArray.Length > secondCharArray.Length)
        {
            for (int index = 0; index < secondCharArray.Length; index++)
            {
                if (firstCharArray[index] == secondCharArray[index])
                {
                    if (index == secondCharArray.Length - 1)
                    {
                        Console.WriteLine(">");
                    }
                    continue;
                }
                else if (firstCharArray[index] < secondCharArray[index])
                {
                    Console.WriteLine("<");
                    break;
                }
                else if (firstCharArray[index] > secondCharArray[index])
                {
                    Console.WriteLine(">");
                    break;
                }
            }
        }

        else if (firstCharArray.Length == secondCharArray.Length)
        {
            for (int index = 0; index < firstCharArray.Length; index++)
            {
                if (firstCharArray[index] == secondCharArray[index])
                {
                    if (index == firstCharArray.Length - 1)
                    {
                        Console.WriteLine("=");
                    }
                    continue;
                }
                else if (firstCharArray[index] < secondCharArray[index])
                {
                    Console.WriteLine("<");
                    break;
                }
                else if (firstCharArray[index] > secondCharArray[index])
                {
                    Console.WriteLine(">");
                    break;
                }
            }
        }
    }
}
