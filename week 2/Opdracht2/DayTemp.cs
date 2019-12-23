using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opdracht2
{
    class DayTemp
    {
        //FIELDS
        private DateTime dayDate;
        private float temp;

        //PROPERTIES
        public DateTime DayDate { get { return dayDate; } set { dayDate = value; } }
        public float Temp { get { return temp; } set { temp = value; } }
        public int WeekNumber { get { return new CultureInfo("nl-NL").Calendar.GetWeekOfYear(dayDate, CalendarWeekRule.FirstDay, DayOfWeek.Monday); } }
        public DayOfWeek WeekDay { get { return DayDate.DayOfWeek; } }

        //CONSTRUCTORS
        public DayTemp(float _temp, DateTime _dayDate)
        {
            temp = _temp;
            DayDate = _dayDate;
        }
        public DayTemp(float _temp)
        {
            temp = _temp;
            DayDate = DateTime.Now;
        }

        //METHODS
        public override string ToString()
        {
            return "Date: " + dayDate + "\n" +
                "Temperature: " + temp + "°C\n" +
                "Week number: " + WeekNumber + "\n" +
                "Week day: " + WeekDay;
        }
    }
}
