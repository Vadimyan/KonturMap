using System.Linq;
using Microsoft.AspNet.Mvc;
using Microsoft.AspNet.Mvc.Filters;

namespace KonturMap.Server.WebApp.Common
{
    public class HeaderAuthorizationFilter : ActionFilterAttribute
    {
	    public override void OnActionExecuting(ActionExecutingContext context)
	    {
		    base.OnActionExecuting(context);
		    var headers = context.HttpContext.Request.Headers;
			if(!headers.ContainsKey("Authorization"))
			{ 
				context.Result = new HttpStatusCodeResult(401);
				return;
			}

		    var token = headers["Authorization"].First();
		    var userId = SessionsService.GetSession(token);

			if (!userId.HasValue)
			{
				context.Result = new HttpStatusCodeResult(401);
				return;
			}
		}
    }
}
