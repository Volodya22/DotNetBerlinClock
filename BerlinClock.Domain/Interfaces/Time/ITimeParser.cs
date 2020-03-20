using System;

namespace BerlinClock.Domain.Interfaces.Time
{
    /// <summary>
    /// 
    /// </summary>
    public interface ITimeParser
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        TimeSpan Parse(string time);
    }
}
