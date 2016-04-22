using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KonturMap.Server.WebApp.ViewModels.Account
{
    public class LoginOutputModel
    {
		public string AuthorizationToken { get; set; }
		public DateTimeOffset Expired { get; set; }

	}
}
