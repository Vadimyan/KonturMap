using System;
using System.Threading.Tasks;
using KonturMap.Server.WebApp.Common;
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

			// todo: implement business logic
			var userId = GetUser(model.DeviceId);
			var token = Guid.NewGuid().ToString();
			SessionsService.AddSession(userId, token);

			return Json(new LoginOutputModel { AuthorizationToken = token, Expired = DateTimeOffset.Now.AddDays(1) });
		}

		private long GetUser(string deviceId)
		{
			return deviceId.GetHashCode();
		}

		[HttpPost("LoginPhone")]
		public async Task<IActionResult> LoginByPhone(LoginByPhoneInputModel model)
		{
			if (!ModelState.IsValid)
				return HttpBadRequest();

			// todo: implement business logic

			return Json(new LoginOutputModel { AuthorizationToken = Guid.NewGuid().ToString(), Expired = DateTimeOffset.Now.AddDays(1) });
		}
	}
}
