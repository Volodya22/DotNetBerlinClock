using System;

namespace BerlinClock.Domain.Interfaces.Row
{
    /// <summary>
    /// 
    /// </summary>
    public interface IRowConverter
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="time"></param>
        /// <returns></returns>
        int Convert(TimeSpan time);
    }
}
