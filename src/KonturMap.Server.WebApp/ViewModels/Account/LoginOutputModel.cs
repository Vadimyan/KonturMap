using System;

namespace KonturMap.Server.WebApp.ViewModels.Account
{
    public class LoginOutputModel
    {
		public string AuthorizationToken { get; set; }
		public DateTimeOffset Expired { get; set; }
    }
}
