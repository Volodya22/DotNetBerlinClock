using System;
using System.Globalization;
using BerlinClock.Domain.Interfaces.Time;

namespace BerlinClock.Domain.Models.Time
{
    public class TimeParser : ITimeParser
    {
        public TimeSpan Parse(string time)
        {
            return DateTime.ParseExact(time, "HH:mm:ss", CultureInfo.InvariantCulture).TimeOfDay;
        }
    }
}
