using System.ComponentModel.DataAnnotations;

namespace KonturMap.Server.WebApp.ViewModels
{
    public class MapModel
    {
		[Required]
		public double MapLatitude { get; set; }

		[Required]
		public double MapLongitude { get; set; }

		[Required]
		public int Radis { get; set; }
	}
}
