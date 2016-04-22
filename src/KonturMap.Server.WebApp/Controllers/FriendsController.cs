using System;
using System.Threading.Tasks;
using KonturMap.Server.WebApp.ViewModels;
using KonturMap.Server.WebApp.ViewModels.Friends;
using Microsoft.AspNet.Mvc;

namespace KonturMap.Server.WebApp.Controllers
{
	[Route("api/[controller]")]
    public class FriendsController : Controller
    {
	    [HttpGet]
	    public async Task<IActionResult> Get()
	    {
		    return Json(new GetFriendsOutputModel { Friends = new [] { new Friend { Name = "John Doe", PhoneNumber = "+79043452457", LastSeen = DateTimeOffset.Now.AddHours(-1) } } });
	    }

		[HttpPost]
	    public async Task<IActionResult> Post(PostFriendsInputModel model)
	    {
		    return Ok();
	    }

		[HttpPost]
		[Route("api/[controller]/{friendId}")]
		public async Task<IActionResult> UpdateFriendStatus(int friendId, UpdateFriendStatusInputModel model)
		{
			return Ok();
		}
    }
}
