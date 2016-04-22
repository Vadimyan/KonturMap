using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

namespace KonturMap.Server.WebApp.Controllers
{
	[Route("api/[controller]")]
    public class FriendsController : Controller
    {
	    [HttpGet]
	    public async Task<IActionResult> Get()
	    {
		    return Ok();
	    }

		[HttpPost]
	    public async Task<IActionResult> Post()
	    {
		    return Ok();
	    }

		[HttpPost]
		[Route("api/[controller]/{friendId}")]
		public async Task<IActionResult> UpdateFriendStatus(int friendId)
		{
			return Ok();
		}
    }
}
