using System;
namespace LineComparisonComputation
{
    public class LineComparison
    {
        int x1,x2,y1,y2;
        public LineComparison(int x1, int x2, int y1, int y2)
        {
            this.x1 = x1;
            this.x2 = x2;
            this.y1 = y1;
            this.y2 = y2;
        }
        public double CalculateLength()
        {
            double result = Math.Sqrt(Math.Pow((x2-x1),2) + Math.Pow((y2-y1),2));
            Console.WriteLine(result);
            return result;
        }
        public void CheckEquality(double line1, double line2)
        {
            if (line1.Equals(line2))
                Console.WriteLine("Both the lines are Equal");
            else
                Console.WriteLine("Lines are not Equal");
        }
    }
}
