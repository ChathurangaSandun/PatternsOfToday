using Strategy.Models;
using System;
using System.Runtime.Caching;

namespace Strategy.Repositories
{
    public class CachedPeopleRepository : PeopleRepository
    {
        private static ObjectCache Cache => MemoryCache.Default;
        private const string CacheKey = "CustomerCache";
        private readonly object _lock = new object();

        public override PeopleResult Get()
        {
            var result = Cache.Get(CacheKey) as PeopleResult;
            if (result == null)
            {
                lock (_lock)
                {
                    result = Cache.Get(CacheKey) as PeopleResult;
                    if (result == null)
                    {
                        result = base.Get();
                        Cache.Set(CacheKey, result, DateTimeOffset.Now.AddSeconds(10));
                    }
                }
            }

            return result;
        }
    }
}
