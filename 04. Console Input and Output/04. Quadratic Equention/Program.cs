/* In case a= -0.5, b= 4, c= -8, discriminant = 0 => have one real root x = -b / 2a
 * (https://www.khanacademy.org/math/algebra2/polynomial_and_rational/quad_formula_tutorial/v/discriminant-of-quadratic-equations)
 */
using System;
using System.Threading;
using System.Globalization;


class QuadraticEquation
{
    static void Main()
    {
        //Console.OutputEncoding = System.Text.Encoding.UTF8;
        //Thread.CurrentThread.CurrentCulture =
        //    CultureInfo.InvariantCulture;
        // Set your console font to 'Consolas'

        Thread.CurrentThread.CurrentCulture =
            CultureInfo.InvariantCulture;

        double coefA = double.Parse(Console.ReadLine());
        double coefB = double.Parse(Console.ReadLine());
        double coefC = double.Parse(Console.ReadLine());

        double discriminant = Math.Pow(coefB, 2) - (4 * coefA * coefC);

        if (coefA == 0)
        {
            double rootX = -(coefC / coefB);
            //Console.WriteLine("The equation is linear! It has only one root! - x = {0}.", rootX);
            Console.WriteLine("{0:0.00}", rootX);
        }
        else if (discriminant < 0)
        {
            Console.WriteLine("no real roots");
        }
        else if (discriminant == 0)
        {
            double rootX = -coefB / (2 * coefA);
            //Console.WriteLine("The quadratic equation has one real root x = {0}", rootX);
            Console.WriteLine("{0:0.00}", rootX);
        }
        else if (discriminant > 0)
        {
            double rootX1 = 0;
            double rootX2 = 0;
            if (coefA != 0)
            {
                rootX1 = (-coefB + Math.Sqrt(discriminant)) / (coefA * 2);
                rootX2 = (-coefB - Math.Sqrt(discriminant)) / (coefA * 2);
            }
            //Console.WriteLine("The real roots of the quadratic equation ax²+bx+c=0 are:\n x₁ = {0}\n x₂ = {1}", rootX1, rootX2);
            if (rootX1 < rootX2)
            {
                Console.WriteLine("{0:0.00}\n{1:0.00}", rootX1, rootX2);
            }
            else Console.WriteLine("{0:0.00}\n{1:0.00}", rootX2, rootX1);
        }
    }
}