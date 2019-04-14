using System;

namespace Singleton.Services
{
    public class SingletonService
    {
        private long _counter;
        
        private static Lazy<SingletonService> _instance = new Lazy<SingletonService>(new SingletonService());
        public static SingletonService Instance => _instance.Value;

        private SingletonService()
        {
            Console.WriteLine($"{nameof(SingletonService)} initialized.");
        }

        public long GetNextNumber()
        {
            return _counter++;
        }
    }
}
