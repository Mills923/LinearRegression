using MathNet.Numerics;
using System;

namespace LinearRegression
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] xweight = new double[] { 165, 185, 190, 210, 180, 150, 180 };
            double[] yheight = new double[] { 66, 71, 70, 72, 72, 67, 68 };
            
            Tuple<double , double> p = Fit.Line(xweight, yheight);
            double a = p.Item1; // intercept
            double b = p.Item2; // slope

            Console.Write("Please input a predictor value (number) : ");
            int predictor = Int32.Parse(Console.ReadLine());
            double predicted = a + b * predictor;
            Console.WriteLine($"The value of alpha is: {a} ");
            Console.WriteLine($"The value of beta is: {b} ");
            Console.WriteLine($"The formula is: y = {a} + {b} * {predictor}");
            Console.WriteLine($"The predicted value is: {predicted}");
            
        }
       
    }
}
