using System;
namespace LineComparisonComputation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Comparison Computation");
            LineComparison lineComparison1 = new LineComparison(12, 15, 16, 24);
            double line1 = lineComparison1.CalculateLength();
            LineComparison lineComparison2 = new LineComparison(13, 19, 24, 45);
            double line2 = lineComparison2.CalculateLength();
            lineComparison2.CheckEquality(line1, line2);
        }
    }
}