using System.ComponentModel.DataAnnotations;
using Microsoft.AspNet.Mvc;

namespace KonturMap.Server.WebApp.ViewModels.Account
{
    public class LoginInputModel
    {
		[Required]
		public string DeviceId { get; set; }
    }
}
