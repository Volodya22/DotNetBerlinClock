using BerlinClock.Domain.Interfaces.Time;

namespace BerlinClock.Domain.Models.Time
{
    public class TimeConverter : ITimeConverter
    {
        private readonly ITimeParser _parser;
        private readonly ITimePrinter _printer;

        public TimeConverter(ITimeParser parser, ITimePrinter printer)
        {
            _parser = parser;
            _printer = printer;
        }

        public string ConvertTime(string aTime)
        {
            var time = _parser.Parse(aTime);
            var result = _printer.Print(time);

            return result;
        }
    }
}
