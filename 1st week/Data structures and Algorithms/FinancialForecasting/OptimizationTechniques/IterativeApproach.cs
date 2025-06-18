/*the iterative approach avoids recursion entirely by using a simple loop.
 It’s more efficient because it doesn't use the call stack and operates in constant stack space,
 offering linear time complexity O(n), but with better performance and no risk of stack overflow*/

 namespace FinancialForecast.OptimizationTechniques
{
    public static class IterativeApproach
    {
        public static double Forecast(double currentValue, double rate, int periods)
        {
            for (int i = 0; i < periods; i++)
            {
                currentValue *= (1 + rate);
            }
            return currentValue;
        }
    }
}


