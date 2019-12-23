using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht2
{
    class WeekOverview : DateOverview
    {
        private DayTemp[] dayTemps = new DayTemp[7];
        public DayTemp[] DayTemps { get { return dayTemps; } set { dayTemps = value; } }


        public float AverageTemperature()
        {
            float temp = 0;
            foreach (DayTemp day in dayTemps)
            {
                if (day != null)
                {
                    temp += day.Temp;
                }
            }
            return temp / dayTemps.Length;
        }

        public float HighestTemperature()
        {
            float temp = 0;
            foreach (DayTemp day in dayTemps)
            {
                if (day != null && day.Temp > temp)
                {
                    temp = day.Temp;
                }
            }
            return temp;
        }

        public float LowestTemperature()
        {
            float temp = float.MaxValue;
            foreach (DayTemp day in dayTemps)
            {
                if (day != null && day.Temp < temp)
                {
                    temp = day.Temp;
                }
            }
            return temp;
        }

        public void AddDayToDayTemps(DayTemp day)
        {
            switch (day.WeekDay)
            {
                case DayOfWeek.Monday:
                    dayTemps[0] = day;
                    break;
                case DayOfWeek.Tuesday:
                    dayTemps[1] = day;
                    break;
                case DayOfWeek.Wednesday:
                    dayTemps[2] = day;
                    break;
                case DayOfWeek.Thursday:
                    dayTemps[3] = day;
                    break;
                case DayOfWeek.Friday:
                    dayTemps[4] = day;
                    break;
                case DayOfWeek.Saturday:
                    dayTemps[5] = day;
                    break;
                case DayOfWeek.Sunday:
                    dayTemps[6] = day;
                    break;
            }
        }
    }
}
