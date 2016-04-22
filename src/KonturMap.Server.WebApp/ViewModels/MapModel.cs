using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

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
