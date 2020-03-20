using BerlinClock.Domain.Interfaces.Time;

namespace BerlinClock.Domain.Interfaces.Factory
{
    public interface IConverterFactory : IFactory<ITimePrinter>
    {
    }
}
