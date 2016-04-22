namespace KonturMap.Server.WebApp.ViewModels.Map
{
    public class GetMapInputModel
    {
		/// <summary>
		/// Cueent map center latitude.
		/// </summary>
		public double MapLatitude { get; set; }

		/// <summary>
		/// Cueent map center longitude.
		/// </summary>
		public double MapLongitude { get; set; }
		
		/// <summary>
		/// Current map scale to retieve only visible friends.
		/// </summary>
		public int Scale { get; set; }
	}
}
