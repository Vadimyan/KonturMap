using System.ComponentModel.DataAnnotations;

namespace KonturMap.Server.WebApp.ViewModels.Account
{
    public class LoginByPhoneInputModel
    {
		[Required]
		public string PhoneNumber { get; set; }

		[Required]
		public string Password { get; set; }
    }
}
