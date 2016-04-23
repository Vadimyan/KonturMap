using System.Linq;
using Microsoft.AspNet.Mvc;

namespace KonturMap.Server.WebApp.Common
{
    public static class AuthorizationHelper
    {
	    public static long? GetInitiatorId(this Controller controller)
	    {
			var headers = controller.HttpContext.Request.Headers;
			if (!headers.ContainsKey("Authorization"))
			{
				return null;
			}

			var token = headers["Authorization"].First();
			return SessionsService.GetSession(token);
	    }
    }
}
