using System;
using System.Threading.Tasks;
using KonturMap.Server.WebApp.Common;
using KonturMap.Server.WebApp.ViewModels.Friends;
using Microsoft.AspNet.Mvc;

namespace KonturMap.Server.WebApp.Controllers
{
	[HeaderAuthorizationFilter]
	[Route("api/[controller]")]
    public class FriendsController : Controller
    {
	    [HttpGet]
	    public async Task<IActionResult> Get()
	    {
			//todo: implement business logic

		    var result = new[]
		    {
			    new GetFriendsOutputModel { Id = 9043452090, LastSeen = DateTimeOffset.Now },
				new GetFriendsOutputModel { Id = 9043452458, LastSeen = DateTime.Today },
				new GetFriendsOutputModel { Id = 9043452458, LastSeen = DateTime.UtcNow }
			};

		    return Json(result);
	    }

		[HttpPost]
	    public async Task<IActionResult> Post(PostFriendsInputModel[] model)
	    {
			//todo: implement business logic

			return Ok();
	    }

		[HttpPost("{friendId}")]
		public async Task<IActionResult> UpdateFriendStatus(int friendId, [FromBody] PostFriendInputModel model)
		{
			//todo: implement business logic
			return Ok();
		}
    }
}
