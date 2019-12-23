using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht2
{
    class Program
    {
        static YearOverview objYearOverview = new YearOverview();
        static void Main(string[] args)
        {
            Console.Clear();

            Console.WriteLine("Select action:");
            Console.WriteLine("1 - Simulate use\n" +
                "2 - Fill with random data\n" +
                "3 - Change value\n");

            string input = Console.ReadLine();

            Console.Clear();
            Console.WriteLine("Type \"back\" to go back to the main menu");

            switch (input)
            {
                case "1":
                    SimulateUse();
                    break;
                case "2":
                    FillWithRandomData();
                    break;
                case "3":
                    ChangeValue();
                    break;
            }

            Main(args);
        }

        static void SimulateUse()
        {
            objYearOverview = new YearOverview();

            objYearOverview.AddWeekToWeekOverviews(new WeekOverview());

            DateTime currentDate = new DateTime(DateTime.Now.Year, 1, 1);
            while (true)
            {
                Console.WriteLine("It's " + currentDate.DayOfWeek + " the " + currentDate.ToShortDateString() + " at 12 am right now, what is the temperature?");

                string input = Console.ReadLine();
                if (input == "back")
                {
                    return;
                }

                float temp = float.Parse(input);

                int currentDateWeekNumber = new CultureInfo("nl-NL").Calendar.GetWeekOfYear(currentDate, CalendarWeekRule.FirstDay, DayOfWeek.Monday) - 1;

                objYearOverview.AddDayToDayTempsOfWeek(new DayTemp(temp, currentDate), currentDateWeekNumber);

                if (currentDate.DayOfWeek == DayOfWeek.Sunday)
                {
                    objYearOverview.AddWeekToWeekOverviews(new WeekOverview());

                    WeekOverview objWeekOverview = objYearOverview.WeekOverviews[currentDateWeekNumber];
                    Console.WriteLine("This is an overview of this week:");
                    Console.WriteLine("The average temperature = " + objWeekOverview.AverageTemperature());
                    Console.WriteLine("The highest temperature = " + objWeekOverview.HighestTemperature());
                    Console.WriteLine("The lowest temperature = " + objWeekOverview.LowestTemperature());
                }

                currentDate = currentDate.AddDays(1);
            }
        }

        static void FillWithRandomData()
        {
            objYearOverview = new YearOverview();
            DateTime fakeDate = new DateTime(DateTime.Now.Year, 1, 1);
            Random rnd = new Random();

            for (int i=0; i<52; i++)
            {
                WeekOverview objWeekOverview = new WeekOverview();
                for (int j=0; j<7; i++)
                {
                    objWeekOverview.AddDayToDayTemps(new DayTemp(rnd.Next(-10, 35), fakeDate));
                    fakeDate.AddDays(1);
                }
                objYearOverview.AddWeekToWeekOverviews(objWeekOverview);
            }
        }

        static void ChangeValue()
        {
            if (objYearOverview.WeekOverviews.Length == 0)
            {
                return;
            }

            string input = Console.ReadLine();
            if (input == "back")
            {
                return;
            }
        }
    }
}
