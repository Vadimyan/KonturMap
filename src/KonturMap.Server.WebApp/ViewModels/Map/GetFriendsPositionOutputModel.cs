using System;

namespace KonturMap.Server.WebApp.ViewModels.Map
{
    public class GetFriendsPositionOutputModel
    {
		public long Id { get; set; }
		public DateTimeOffset LastSeen { get; set; }
		public double Latitude { get; set; }
		public double Longitude { get; set; }

		public GetFriendsPositionOutputModel() { }

		public GetFriendsPositionOutputModel(long id, DateTimeOffset lastSeen, double latitude, double longitude)
		{
			Id = id;
			LastSeen = lastSeen;
			Latitude = latitude;
			Longitude = longitude;
		}
	}
}
