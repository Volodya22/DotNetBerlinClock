using BerlinClock.Domain.Interfaces.Time;

namespace BerlinClock.Domain.Interfaces.Factory
{
    /// <summary>
    /// Interface for converters factory
    /// </summary>
    public interface IConverterFactory : IFactory<ITimePrinter>
    {
    }
}
