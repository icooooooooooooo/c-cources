using System;

class PriceChangeAlert
{
    static void Main()
    {
        int numOfPrices = int.Parse(Console.ReadLine());
        double significanceTreshhold = double.Parse(Console.ReadLine());
        double initialPrice = double.Parse(Console.ReadLine());

        for (int i = 1; i < numOfPrices; i++)
        {
            double secondaryPrices = double.Parse(Console.ReadLine());
            double percentDifference = PercentDifferenceValue(initialPrice, secondaryPrices);

            bool isSignificantDifference = IsDiffSignificant(percentDifference, significanceTreshhold);

            string resultMessage = ComparePrices(secondaryPrices, initialPrice, percentDifference, isSignificantDifference);

            Console.WriteLine(resultMessage);
            initialPrice = secondaryPrices;
        }
    }

    private static string ComparePrices(double secondaryPrice, double initialPrice, double differenceInPercent, bool isSignificantDifference)
    {
        //            string resultMessage = ComparePrices(secondaryPrices, initialPrice, percentDifference, isSignificantDifference);

        string resultMessage = "";

        if (differenceInPercent == 0)
        {
            resultMessage = string.Format("NO CHANGE: {0}", secondaryPrice);
        }
        else if (!isSignificantDifference)
        {
            resultMessage = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", initialPrice, secondaryPrice, differenceInPercent);
        }
        else if (isSignificantDifference && (differenceInPercent > 0))
        {
            resultMessage = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", initialPrice, secondaryPrice, differenceInPercent);
        }
        else if (isSignificantDifference && (differenceInPercent < 0))
        {
            resultMessage = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", initialPrice, secondaryPrice, differenceInPercent);
        }
        return resultMessage;
    }
    private static bool IsDiffSignificant(double currentDifference, double differrenceTreshhold)
    {

        if (Math.Abs(currentDifference) >= differrenceTreshhold)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    private static double PercentDifferenceValue(double initialPrice, double secondaryPrice)
    {
        double percentDifference = (secondaryPrice - initialPrice) / initialPrice;
        return percentDifference;
    }
}