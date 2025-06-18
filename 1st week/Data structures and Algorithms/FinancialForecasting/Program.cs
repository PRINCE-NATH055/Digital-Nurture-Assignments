using System;
using FinancialForecast.OptimizationTechniques;

class Program
{
    static double ForecastRecursive(double currentValue, double rate, int periods)
    {
        if (periods == 0)
            return currentValue;

        return ForecastRecursive(currentValue * (1 + rate), rate, periods - 1);
    }

    static void Main()
    {
        double initialValue = 1000;
        double rate = 0.05;
        int periods = 5;

        Console.WriteLine("Financial Forecasting Comparison");

        double recursiveResult = ForecastRecursive(initialValue, rate, periods);
        Console.WriteLine($"1. Recursive: {recursiveResult:F2} (O(n))");

        double iterativeResult = IterativeApproach.Forecast(initialValue, rate, periods);
        Console.WriteLine($"3. Iterative: {iterativeResult:F2} (O(n), most efficient)");
    }
}
