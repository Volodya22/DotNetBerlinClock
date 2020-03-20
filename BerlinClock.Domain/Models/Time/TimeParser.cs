using System;
using System.Globalization;
using BerlinClock.Domain.Interfaces.Time;

namespace BerlinClock.Domain.Models.Time
{
    public class TimeParser : ITimeParser
    {
        private const string MidnigthWith24Hours = "24:00:00";

        public TimeSpan Parse(string time)
        {
            if (time == MidnigthWith24Hours)
            {
                return new TimeSpan(24, 0, 0);
            }

            return DateTime.ParseExact(time, "HH:mm:ss", CultureInfo.InvariantCulture).TimeOfDay;
        }
    }
}
