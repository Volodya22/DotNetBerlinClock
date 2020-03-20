using BerlinClock.Domain.Interfaces.Row;
using System;

namespace BerlinClock.Domain.Models.Row.Converters
{
    class MinutesFirstRowConverter : IRowConverter
    {
        public int Convert(TimeSpan time)
        {
            return time.Minutes / 5;
        }
    }
}
