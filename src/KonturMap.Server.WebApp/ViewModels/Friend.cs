using System;

namespace KonturMap.Server.WebApp.ViewModels
{
    public class Friend
    {
		public string PhoneNumber { get; set; }
		public string Name { get; set; }
		public DateTimeOffset LastSeen { get; set; }
    }
}
