using BerlinClock.Domain.Interfaces.Row;
using BerlinClock.Domain.Interfaces.Time;
using System;

namespace BerlinClock.Domain.Models.Time
{
    public class TimePrinter : ITimePrinter
    {
        private readonly IRowConverter _rowConverter;
        private readonly IRowPrinter _rowPrinter;

        public TimePrinter(IRowConverter rowConverter, IRowPrinter rowPrinter)
        {
            _rowConverter = rowConverter;
            _rowPrinter = rowPrinter;
        }

        public string Print(TimeSpan time)
        {
            var lights = _rowConverter.Convert(time);

            return _rowPrinter.Print(lights);
        }
    }
}
