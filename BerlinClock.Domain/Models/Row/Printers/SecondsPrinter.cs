using BerlinClock.Domain.Helpers;
using BerlinClock.Domain.Interfaces.Row;

namespace BerlinClock.Domain.Models.Row.Printers
{
    class SecondsPrinter : IRowPrinter
    {
        public string Print(int number)
        {
            return number == 0 ? new string(new[]{ Constants.None }) : new string(new[] { Constants.Yellow });
        }
    }
}
