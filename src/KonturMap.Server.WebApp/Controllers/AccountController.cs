using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

namespace KonturMap.Server.WebApp.Controllers
{
    public class AccountController : Controller
    {
		[HttpPost("RegisterDevice")]
		public async Task<IActionResult> RegisterDevice()
	    {
		    if (!ModelState.IsValid)
			    return HttpBadRequest();

			return Ok();
	    }

		[HttpPost("Login")]
		public async Task<IActionResult> Login()
		{
			if (!ModelState.IsValid)
				return HttpBadRequest();

			return Ok();
		}
	}
}
