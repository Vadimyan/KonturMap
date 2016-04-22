using System.ComponentModel.DataAnnotations;

namespace KonturMap.Server.WebApp.ViewModels.Account
{
    public class RegisterDeviceInputModel
    {
		[Required]
		public string DeviceId { get; set; }

		[Required]
		public string OwnerNumber { get; set; }
		public string OwnerName { get; set; }
    }
}
