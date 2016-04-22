using System;
using System.Threading.Tasks;
using KonturMap.Server.WebApp.ViewModels.Account;
using Microsoft.AspNet.Mvc;

namespace KonturMap.Server.WebApp.Controllers
{
    public class AccountController : Controller
    {
		[HttpPost]
		public async Task<IActionResult> RegisterDevice(RegisterDeviceInputModel model)
	    {
		    if (!ModelState.IsValid)
			    return HttpBadRequest();

			return Ok();
	    }

		[HttpPost]
		public async Task<IActionResult> Login(LoginInputModel model)
		{
			if (!ModelState.IsValid)
				return HttpBadRequest();

			return Json(new LoginOutputModel { AuthorizationToken = "TempToken", Expired = DateTimeOffset.Now.AddDays(1) });
		}
	}
}
