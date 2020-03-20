﻿using BerlinClock.Domain.Interfaces.Row;
using System;

namespace BerlinClock.Domain.Models.Row.Converters
{
    class HoursSecondRowConverter : IRowConverter
    {
        public int Convert(TimeSpan time)
        {
            return time.Hours % 5;
        }
    }
}
