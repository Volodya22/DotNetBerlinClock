namespace BerlinClock.Domain.Interfaces.Time
{
    /// <summary>
    /// Interface for Berlin Clock time converter
    /// </summary>
    public interface ITimeConverter
    {
        /// <summary>
        /// Convert time into Berlin Clock time
        /// </summary>
        /// <param name="aTime">Time</param>
        /// <returns>Berlin Clock time</returns>
        string ConvertTime(string aTime);
    }
}
