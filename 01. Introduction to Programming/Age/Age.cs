using System;
using System.Globalization;
using System.Threading;

namespace Age
{
    class Age
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            DateTime birthday = DateTime.Parse(Console.ReadLine());
            DateTime now = DateTime.Now;
            int age = now.Year - birthday.Year;


            if (now.Month <= birthday.Month && now.Day < birthday.Day)
            {
                age--;
            }
            Console.WriteLine("{0}\n{1}", age -1, age + 9);
                        
            //if (birthday.Month > now.Month)
            //{
            //    Console.WriteLine(age - 1);
            //    Console.WriteLine(age + 9);
            //}
            //else if(birthday.Month == now.Month && birthday.Day >= now.Day)
            //{
            //    Console.WriteLine(age);
            //    Console.WriteLine(age + 10);
            //}
            //else if (birthday.Month == now.Month && birthday.Day < now.Day)
            //{
            //    Console.WriteLine(age - 1);
            //    Console.WriteLine(age + 9);
            //}
            //else if (birthday.Month < now.Month)
            //{
            //    Console.WriteLine(age);
            //    Console.WriteLine(age + 10);
            //}
            //else
            //{
            //    Console.WriteLine(age - 1);
            //    Console.WriteLine(age + 9);
            //}
        }
    }
}