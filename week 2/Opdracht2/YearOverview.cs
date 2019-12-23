using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht2
{
    class YearOverview : DateOverview
    {
        private WeekOverview[] weekOverviews = new WeekOverview[52];

        public WeekOverview[] WeekOverviews { get { return weekOverviews; } set { weekOverviews = value; } }

        public void AddWeekToWeekOverviews(WeekOverview week)
        {
            int weekNumber;
            if (week.DayTemps[0] != null)
            {
                weekNumber = new CultureInfo("nl-NL").Calendar.GetWeekOfYear(week.DayTemps[0].DayDate, CalendarWeekRule.FirstDay, DayOfWeek.Monday);
            }
            else
            {
                weekNumber = 0;
            }
            
            weekOverviews[weekNumber] = week;
        }

        public void AddDayToDayTempsOfWeek(DayTemp day, int index)
        {
            weekOverviews[index].AddDayToDayTemps(day);
        }
    }
}
