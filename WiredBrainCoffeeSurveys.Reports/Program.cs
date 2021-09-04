using System;

namespace WiredBrainCoffeeSurveys.Reports
{
    class Program
    {
        static void Main(string[] args)
        {
            //CALCULATED VALUES
            // declaration statements to declare new variables followed by expression statements to assign values to the variables
            double responseRate = Q1Results.NumberResponded / Q1Results.NumberSurveyed;
            double unansweredCount = Q1Results.NumberSurveyed - Q1Results.NumberResponded;

            // add all scores and divide by number of categories to get an overall score. stores a decimal value, so use double.
            double overallScore = (Q1Results.ServiceScore + Q1Results.CoffeeScore + Q1Results.FoodScore + Q1Results.PriceScore) / 4;

            // expression statements that print the values stored in our variables
            Console.WriteLine($"Response Percentage: {responseRate}");
            Console.WriteLine($"Unanswered Surveys: {unansweredCount}");
            Console.WriteLine($"Overall Score: {overallScore}");

            //LOGICAL COMPARISONS
            bool higherCoffeeScore = Q1Results.CoffeeScore > Q1Results.FoodScore;
            bool customerRecommend = Q1Results.WouldRecommend >= 7;
            bool noGranolaYesCappucino = Q1Results.LeastFavoriteProduct == "Granola" && Q1Results.FavoriteProduct == "Cappucino";

            // expression statements that print the values stored in our variables
            Console.WriteLine($"Is the coffee score higher than the food score?: {higherCoffeeScore}");
            Console.WriteLine($"Would customers recommend us?: {customerRecommend}");
            Console.WriteLine($"Is granola least popular? Cappucino most popular?: {noGranolaYesCappucino}");

        }
    }
}
