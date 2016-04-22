using System;
using System.Threading.Tasks;
using KonturMap.Server.WebApp.ViewModels.Map;
using Microsoft.AspNet.Mvc;

namespace KonturMap.Server.WebApp.Controllers
{
	
    public class MapController : Controller
    {
	    [HttpGet]
		[Route("api/Friends/Position")]
		public async Task<IActionResult> GetFriendsPosition(GetFriendsPositionInputModel model)
	    {
		    if (!ModelState.IsValid)
			    return HttpBadRequest();

			//todo: implement business logic

			return Json(new[]
		    {
			    new GetFriendsPositionOutputModel(9043452457, DateTime.Today, 57.3534663, 81.5436567),
			    new GetFriendsPositionOutputModel(9095113259, DateTime.Today, 57.3534635, 81.1237644),
			    new GetFriendsPositionOutputModel(9286576123, DateTime.Today, 57.3534664, 81.2377643)
		    });
	    }

		[HttpGet]
		[Route("api/Friends/{id}/Position")]
		public async Task<IActionResult> GetFriendPosition(long id)
		{
			//todo: implement business logic

			return Json(new GetFriendsPositionOutputModel(id, DateTime.Today, 57.3534663, 81.5436567));
		}
	}
}
