using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

namespace KonturMap.Server.WebApp.Controllers
{
    public class PositionController : Controller
    {
		[HttpPost]
	    public async Task<IActionResult> Post()
	    {
		    return Ok();
	    }
    }
}
