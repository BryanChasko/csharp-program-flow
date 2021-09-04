 using System;
using System.Collections.Generic;

namespace WiredBrainCoffeeSurveys.Reports
{
    class Program
    {
        static void Main(string[] args)
        {
            var tasks = new List<string>();
            //CALCULATED VALUES
            // declaration statements to declare new variables followed by expression statements to assign values to the variables
            double responseRate = Q1Results.NumberResponded / Q1Results.NumberSurveyed;
            double overallScore = (Q1Results.ServiceScore + Q1Results.CoffeeScore + Q1Results.FoodScore + Q1Results.PriceScore) / 4;

            //LOGICAL COMPARISONS
            bool isCoffeeScoreLower = Q1Results.CoffeeScore < Q1Results.FoodScore;

            if (isCoffeeScoreLower)
            {
                tasks.Add("Investigate coffee recipes and ingredients.");
            }

             if (overallScore > 8.0)
            {
                tasks.Add("Work with leadership to reward staff");
            }
            else
            {
                tasks.Add("Work with employees for improvement ideas.");
            }
             if (responseRate < .33)
            {
                tasks.Add("Research options to improve response rate.");
            }
             else if (responseRate > .33 && responseRate < .66)
            {
                tasks.Add("Reward participants with free cofee coupon.");
            }
             //only possible left scenario would be if response rate is over .66
             else
            {
                tasks.Add("Reward participants with discount cofee coupon.");
            }
             // SWITCH STATEMENT TO FIND USER FEEDBACK ON HOW TO IMPROVE
             switch (Q1Results.AreaToImprove)
            {
                //break tells the program flow to exit out of the switch statement once matched case has been executed.
                case "RewardsProgram":
                    tasks.Add("Revisit the rewards deals.");
                    break;

                case "Cleanliness":
                    tasks.Add("Contact the cleaning vendor.");
                    break;

                case "MobileApp":
                    tasks.Add("Contact consulting firm about the app.");
                    break;

                default:
                    tasks.Add("Investigate individual comments for ideas.");
                    break;
            }
        }
    }
}
