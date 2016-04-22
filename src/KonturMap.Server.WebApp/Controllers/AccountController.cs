using System;
using System.Threading.Tasks;
using KonturMap.Server.WebApp.ViewModels.Account;
using Microsoft.AspNet.Mvc;

namespace KonturMap.Server.WebApp.Controllers
{
	[Route("api/[controller]")]
	public class AccountController : Controller
    {
		[HttpPost("RegisterDevice")]
		public async Task<IActionResult> RegisterDevice(RegisterDeviceInputModel model)
	    {
		    if (!ModelState.IsValid)
			    return HttpBadRequest();

			// todo: implement business logic

			return Ok();
	    }

		[HttpPost("Login")]
		public async Task<IActionResult> Login(LoginInputModel model)
		{
			if (!ModelState.IsValid)
				return HttpBadRequest();

			return Json(new LoginOutputModel { AuthorizationToken = Guid.NewGuid().ToString(), Expired = DateTimeOffset.Now.AddDays(1) });
		}
	}
}
