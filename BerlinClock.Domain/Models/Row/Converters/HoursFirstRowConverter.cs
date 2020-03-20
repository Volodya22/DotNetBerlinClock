using BerlinClock.Domain.Interfaces.Row;
using System;

namespace BerlinClock.Domain.Models.Row.Converters
{
    class HoursFirstRowConverter : IRowConverter
    {
        public int Convert(TimeSpan time)
        {
            return (int)time.TotalHours / 5;
        }
    }
}
