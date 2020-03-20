using BerlinClock.Domain.Helpers;
using BerlinClock.Domain.Interfaces.Row;
using System;
using System.Text;

namespace BerlinClock.Domain.Models.Row.Printers
{
    class MinutesFirstRowPrinter : IRowPrinter
    {
        private const int LightsCount = 11;

        public string Print(int number)
        {
            var sb = new StringBuilder();

            for (var i = 0; i < LightsCount; i++)
            {
                if (i < number)
                {
                    if (i % 3 == 2)
                    {
                        sb.Append(Constants.Red);
                    }
                    else
                    {
                        sb.Append(Constants.Yellow);
                    }
                }
                else
                {
                    sb.Append(Constants.None);
                }
            }

            return sb.ToString();
        }
    }
}
