using BerlinClock.Domain.Interfaces.Row;
using System;

namespace BerlinClock.Domain.Models.Row.Converters
{
    class MinutesSecondRowConverter : IRowConverter
    {
        public int Convert(TimeSpan time)
        {
            return time.Minutes % 5;
        }
    }
}
