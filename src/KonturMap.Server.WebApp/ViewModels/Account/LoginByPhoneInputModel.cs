using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

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
