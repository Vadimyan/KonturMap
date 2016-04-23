using System;
using System.Threading.Tasks;
using KonturMap.Server.DAL;
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

			var number = PhoneConverter.Convert(model.OwnerNumber);
			var result = await UserModel.RegNewUser(number, model.Password, model.DeviceId);

			return result ? Ok() : new HttpStatusCodeResult(500);
	    }

		[HttpPost("Login")]
		public async Task<IActionResult> Login(LoginInputModel model)
		{
			if (!ModelState.IsValid)
				return HttpBadRequest();

			var userId = await UserModel.LoginByDeviceID(model.DeviceId);

			var token = Guid.NewGuid().ToString();
			SessionsService.AddSession(userId, token);

			return Json(new LoginOutputModel { AuthorizationToken = token, Expired = DateTimeOffset.Now.AddDays(1) });
		}

		[HttpPost("LoginPhone")]
		public async Task<IActionResult> LoginByPhone(LoginByPhoneInputModel model)
		{
			if (!ModelState.IsValid)
				return HttpBadRequest();

			var number = PhoneConverter.Convert(model.PhoneNumber);
			bool result = await UserModel.LoginByPhone(number, model.Password);

			if (result)
			{
				var token = Guid.NewGuid().ToString();
				SessionsService.AddSession(number, token);
				return Json(new LoginOutputModel { AuthorizationToken = token, Expired = DateTimeOffset.Now.AddDays(1) });
			}

			return HttpNotFound();
		}
	}
}
