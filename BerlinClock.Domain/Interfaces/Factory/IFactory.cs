namespace BerlinClock.Domain.Interfaces.Factory
{
    /// <summary>
    /// Factory interface
    /// </summary>
    /// <typeparam name="T">Type of object</typeparam>
    public interface IFactory<T>
    {
        /// <summary>
        /// Creation of an object
        /// </summary>
        /// <returns>New object</returns>
        T Create();
    }
}
