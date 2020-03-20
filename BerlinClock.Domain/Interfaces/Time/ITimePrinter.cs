using System;

namespace BerlinClock.Domain.Interfaces.Time
{
    /// <summary>
    /// 
    /// </summary>
    public interface ITimePrinter
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        string Print(TimeSpan time);
    }
}
