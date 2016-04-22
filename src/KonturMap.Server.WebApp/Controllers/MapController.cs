using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;

namespace KonturMap.Server.WebApp.Controllers
{
    public class MapController : Controller
    {
	    [HttpGet]
	    public async Task<IActionResult> Get()
	    {
		    return Ok();
	    }
    }
}
