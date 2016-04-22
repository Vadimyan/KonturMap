using System.ComponentModel.DataAnnotations;

namespace KonturMap.Server.WebApp.ViewModels.Map
{
	public class GetFriendsPositionInputModel
	{
		[Required]
		public double MapLatitude { get; set; }

		[Required]
		public double MapLongitude { get; set; }

		[Required]
		public int Radis { get; set; }
	}
}
