namespace BerlinClock.Domain.Interfaces.Factory
{
    /// <summary>
    /// 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IFactory<T>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        T Create();
    }
}
