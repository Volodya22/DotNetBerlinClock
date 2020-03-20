using System;

namespace BerlinClock.Domain.Interfaces.Time
{
    /// <summary>
    /// Interface for time printer
    /// </summary>
    public interface ITimePrinter
    {
        /// <summary>
        /// Prints time for clock or it's row
        /// </summary>
        /// <param name="time">Time</param>
        /// <returns>Printed time</returns>
        string Print(TimeSpan time);
    }
}
