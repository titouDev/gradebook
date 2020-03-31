using System;

namespace GradeBook
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = new double[3] {12.5, 10.48, 20};
            // same as                     
            // var numbers = new[] {12.5, 10.48, 20};
            double result = 0;

            foreach(double number in numbers)
            {
                result += number;
            }
            System.Console.WriteLine(result);


            if(args.Length > 0)
            {
                Console.WriteLine($"Hello {args[0]}!");
            }
            else
            {
                Console.WriteLine("Hello !");
            }
        }
    }
}
