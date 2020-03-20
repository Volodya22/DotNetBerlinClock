using System;

namespace BerlinClock.Domain.Interfaces.Time
{
    /// <summary>
    /// Interface for time parser
    /// </summary>
    public interface ITimeParser
    {
        /// <summary>
        /// Parse time string into TimeSpan
        /// </summary>
        /// <param name="time">Time string</param>
        /// <returns>Time TimeSpan</returns>
        TimeSpan Parse(string time);
    }
}
