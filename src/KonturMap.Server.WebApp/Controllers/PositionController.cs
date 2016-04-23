using System.Threading.Tasks;
using KonturMap.Server.WebApp.Common;
using KonturMap.Server.WebApp.ViewModels.Position;
using Microsoft.AspNet.Mvc;

namespace KonturMap.Server.WebApp.Controllers
{
	[HeaderAuthorizationFilter]
	[Route("api/[controller]")]
	public class PositionController : Controller
    {
		[HttpGet]
		public async Task<IActionResult> Get(GetPositionInputModel model)
		{
			if (!ModelState.IsValid)
				return HttpBadRequest(ModelState);

			//todo: implement business logic

			return Json(new []
			{
				new GetPositionOuputModel(57.5474322, 78.4778909),
				new GetPositionOuputModel(57.86854574, 77.8986754)
			});
		}

		[HttpPost]
	    public async Task<IActionResult> Post(PostPositionInputModel model)
		{
			if (!ModelState.IsValid)
				return HttpBadRequest(ModelState);

			//todo: implement business logic

			return Ok();
	    }
    }
}
