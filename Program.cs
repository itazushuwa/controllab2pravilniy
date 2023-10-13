using System;
using SumSeriesLib1;

class Program
{
    static void Main()
    {
        double x = 0.5;
        double eps = 0.001;

        Calculation calculation = new Calculation();
        List<double> seriesValues = calculation.CalculateSumSeries(x, eps);

        foreach (double value in seriesValues)
        {
            Console.WriteLine(value);
        }
    }
}