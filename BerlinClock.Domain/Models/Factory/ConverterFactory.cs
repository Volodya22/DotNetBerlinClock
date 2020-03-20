using System.Collections.Generic;
using BerlinClock.Domain.Interfaces.Factory;
using BerlinClock.Domain.Interfaces.Time;
using BerlinClock.Domain.Models.Row.Converters;
using BerlinClock.Domain.Models.Row.Printers;
using BerlinClock.Domain.Models.Time;

namespace BerlinClock.Domain.Models.Factory
{
    public class ConverterFactory : IConverterFactory
    {
        public ITimePrinter Create()
        {
            var converters = new List<ITimePrinter>()
            {
                new TimePrinter(new SecondsConverter(), new SecondsPrinter()),
                new TimePrinter(new HoursFirstRowConverter(), new HoursFirstRowPrinter()),
                new TimePrinter(new HoursSecondRowConverter(), new HoursSecondRowPrinter()),
                new TimePrinter(new MinutesFirstRowConverter(), new MinutesFirstRowPrinter()),
                new TimePrinter(new MinutesSecondRowConverter(), new MinutesSecondRowPrinter())
            };

            return new BerlinClockPrinter(converters);
        }
    }
}
