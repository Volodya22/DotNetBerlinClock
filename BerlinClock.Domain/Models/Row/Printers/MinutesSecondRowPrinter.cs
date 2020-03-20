using BerlinClock.Domain.Helpers;
using BerlinClock.Domain.Interfaces.Row;

namespace BerlinClock.Domain.Models.Row.Printers
{
    class MinutesSecondRowPrinter : IRowPrinter
    {
        private const int LightsCount = 4;

        public string Print(int number)
        {
            return new string(Constants.Yellow, number) + new string(Constants.None, LightsCount - number);
        }
    }
}
