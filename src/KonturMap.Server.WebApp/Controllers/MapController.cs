using System;
using System.Threading.Tasks;
using KonturMap.Server.WebApp.ViewModels;
using KonturMap.Server.WebApp.ViewModels.Map;
using Microsoft.AspNet.Mvc;

namespace KonturMap.Server.WebApp.Controllers
{
    public class MapController : Controller
    {
	    [HttpGet]
	    public async Task<IActionResult> Get(GetMapInputModel model)
	    {
		    return
			    Json(new GetMapOutputModel
			    {
				    Friends =
					    new[]
					    {
						    new FriendPosition { Name = "John Doe", Position = new Position { Latitude = 57.8, Longitude = 2.9 }, LastSeen = DateTimeOffset.Now, PhoneNumber = "+1456132132" },
						    new FriendPosition { Name = "Chuck Norris", Position = new Position { Latitude = 0, Longitude = 0 }, LastSeen = DateTimeOffset.Now.AddHours(-2.5) }
					    }
			    });
	    }
    }
}
