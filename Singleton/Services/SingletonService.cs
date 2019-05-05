using Microsoft.Extensions.Logging;

namespace Singleton.Services
{
    public class SingletonService : ISingletonService
    {
        private long _counter;

        public SingletonService(ILogger<SingletonService> logger)
        {
            logger.LogInformation($"{nameof(SingletonService)} initialized");
        }

        public long GetNextNumber()
        {
            return _counter++;
        }
    }
}
