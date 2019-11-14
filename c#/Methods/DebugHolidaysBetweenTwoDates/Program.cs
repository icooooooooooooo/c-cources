using System;
using System.Globalization;

class HolidaysBetweenTwoDates
{
    static void Main()
    {
        string pattern1 = "dd.m.yyyy";
        DateTime startDate = DateTime.TryParseExact(Console.ReadLine(), "dd.m.yyyy");//, CultureInfo.InvariantCulture);
        DateTime endDate = DateTime.TryParseExact(Console.ReadLine(), "dd.m.yyyy");//, //,"dd.m.yyyy", CultureInfo.InvariantCulture);
        int holidaysCount = 0;

        for (DateTime date = startDate; date <= endDate; date.AddDays(1))
        {

            if (date.DayOfWeek == DayOfWeek.Saturday && date.DayOfWeek == DayOfWeek.Sunday)
            {
                holidaysCount++; 
            }
        }
        Console.WriteLine(holidaysCount);
    }
}
