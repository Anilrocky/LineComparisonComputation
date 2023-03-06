using System;
namespace LineComparisonComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation");
            Console.WriteLine("Enter x1");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter x2");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y1");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter y2");
            int y2 = Convert.ToInt32(Console.ReadLine());
            LineComparison lineComparison = new LineComparison(x1,x2,y1,y2);
            lineComparison.CalculateLength();
        }
    }
}