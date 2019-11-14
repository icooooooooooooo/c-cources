using System;
using System.Globalization;

namespace CountWorkingDays
{
    class Program
    {
        static void Main(string[] args)
        {
            /*•	All days that are official holidays in Bulgaria:
o	New Year Eve (1 Jan)
o	Liberation Day (3 March)
o	Worker’s day (1 May)
o	Saint George’s Day (6 May)
o	Saints Cyril and Methodius Day (24 May)
o	Unification Day (6 Sept)
o	Independence Day (22 Sept)
o	National Awakening Day (1 Nov)
o	Christmas (24, 25 and 26 Dec)
*/
            DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            DateTime endDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);

            double daysCount = (endDate - startDate).TotalDays;
            int count = 0;
            bool isHoliday = false;

            DateTime[] holidays = new DateTime[]
            {
                   DateTime.ParseExact("01-01-1970","dd-MM-yyyy", CultureInfo.InvariantCulture),
                   DateTime.ParseExact("03-03-1970","dd-MM-yyyy", CultureInfo.InvariantCulture),
                   DateTime.ParseExact("01-05-1970","dd-MM-yyyy", CultureInfo.InvariantCulture),
                   DateTime.ParseExact("06-05-1970","dd-MM-yyyy", CultureInfo.InvariantCulture),
                   DateTime.ParseExact("24-05-1970","dd-MM-yyyy", CultureInfo.InvariantCulture),
                   DateTime.ParseExact("06-09-1970","dd-MM-yyyy", CultureInfo.InvariantCulture),
                   DateTime.ParseExact("22-09-1970","dd-MM-yyyy", CultureInfo.InvariantCulture),
                   DateTime.ParseExact("01-10-1970","dd-MM-yyyy", CultureInfo.InvariantCulture),
                   DateTime.ParseExact("24-12-1970","dd-MM-yyyy", CultureInfo.InvariantCulture),
                   DateTime.ParseExact("25-12-1970","dd-MM-yyyy", CultureInfo.InvariantCulture),
                   DateTime.ParseExact("26-12-1970","dd-MM-yyyy", CultureInfo.InvariantCulture)
            };

            for (DateTime i = startDate; i <= endDate; i = i.AddDays(1))
            {
                if (i.DayOfWeek.Equals(DayOfWeek.Saturday) || i.DayOfWeek.Equals(DayOfWeek.Sunday))
                {
                    isHoliday = true;
                }

                for (int j = 0; j < holidays.Length; j++)
                {
                    if (i.Day.Equals(holidays[j].Day) && i.Month.Equals(holidays[j].Month))
                    {
                        isHoliday = true;
                    }
                }

                if (isHoliday == false)
                {
                    count++;
                }

                isHoliday = false;
            }
            Console.WriteLine(count);
        }
    }
}
