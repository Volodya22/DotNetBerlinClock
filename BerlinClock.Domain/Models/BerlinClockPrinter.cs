using BerlinClock.Domain.Interfaces.Time;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BerlinClock.Domain.Models
{
    class BerlinClockPrinter : ITimePrinter
    {
        private readonly IEnumerable<ITimePrinter> _timePrinters;

        public BerlinClockPrinter(IEnumerable<ITimePrinter> timePrinters)
        {
            _timePrinters = timePrinters;
        }

        public string Print(TimeSpan time)
        {
            var rows = _timePrinters.Select(p => p.Print(time));

            return string.Join("\r\n", rows);
        }
    }
}
