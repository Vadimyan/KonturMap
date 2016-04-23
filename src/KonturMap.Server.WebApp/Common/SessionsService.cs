using System;
using Microsoft.Extensions.Caching.Memory;

namespace KonturMap.Server.WebApp.Common
{
	// todo: instantiate and DI after publish
    public class SessionsService
    {
		private static MemoryCache sessionsCache = new MemoryCache(new MemoryCacheOptions());

	    public static void AddSession(long userId, string token)
	    {
		    var options = new MemoryCacheEntryOptions();
			options.AbsoluteExpirationRelativeToNow = TimeSpan.FromDays(1);

			sessionsCache.Set(token, userId, options);
	    }

	    public static long? GetSession(string token)
	    {
		    string userId;
		    if (sessionsCache.TryGetValue(token, out userId))
		    {
			    return long.Parse(userId);
		    }

		    return null;
	    }
    }
}
