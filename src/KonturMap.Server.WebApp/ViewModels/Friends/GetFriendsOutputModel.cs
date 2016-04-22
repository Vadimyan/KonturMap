using System;

namespace KonturMap.Server.WebApp.ViewModels.Friends
{
    public class GetFriendsOutputModel
    {
		public long	Id { get; set; }
		public DateTimeOffset LastSeen { get; set; }
    }
}
