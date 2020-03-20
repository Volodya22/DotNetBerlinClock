using BerlinClock.Domain.Interfaces.Row;
using System;

namespace BerlinClock.Domain.Models.Row.Converters
{
    class SecondsConverter : IRowConverter
    {
        public int Convert(TimeSpan time)
        {
            return time.Seconds % 2 == 0 ? 1 : 0;
        }
    }
}
