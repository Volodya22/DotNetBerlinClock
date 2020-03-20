namespace BerlinClock.Domain.Interfaces.Row
{
    /// <summary>
    /// Interface for Berlin Clock row time printer
    /// </summary>
    public interface IRowPrinter
    {
        /// <summary>
        /// Print a number of ligths in row
        /// </summary>
        /// <param name="number">Number of lights</param>
        /// <returns>Row</returns>
        string Print(int number);
    }
}
