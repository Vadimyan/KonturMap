using System.ComponentModel.DataAnnotations;

namespace KonturMap.Server.WebApp.ViewModels.Position
{
    public class PostPositionInputModel
    {
		[Required]
		public double Latitude { get; set; }

		[Required]
		public double Longitude { get; set; }
	}
}
