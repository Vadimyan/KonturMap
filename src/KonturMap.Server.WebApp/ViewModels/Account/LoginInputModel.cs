using System.ComponentModel.DataAnnotations;

namespace KonturMap.Server.WebApp.ViewModels.Account
{
    public class LoginInputModel
    {
		[Required]
		public string DeviceId { get; set; }
    }
}
