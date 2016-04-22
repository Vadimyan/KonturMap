namespace KonturMap.Server.WebApp.ViewModels.Position
{
	public class GetPositionOuputModel
	{
		public double Latitude { get; set; }
		public double Longitude { get; set; }

		public GetPositionOuputModel() { }

		public GetPositionOuputModel(double latitude, double longitude)
		{
			Latitude = latitude;
			Longitude = longitude;
		}
	}
}