using System;

namespace BerlinClock.Domain.Interfaces.Row
{
    /// <summary>
    /// Interface for Berlin Clock row converter
    /// </summary>
    public interface IRowConverter
    {
        /// <summary>
        /// Converts time into amount lights on in row
        /// </summary>
        /// <param name="time">Time</param>
        /// <returns>Amount of lights</returns>
        int Convert(TimeSpan time);
    }
}
