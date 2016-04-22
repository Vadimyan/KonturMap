using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using KonturMap.Server.WebApp.ViewModels;
using Microsoft.AspNet.Mvc;

namespace KonturMap.Server.WebApp.Controllers
{
    public class PositionController : Controller
    {
		[HttpPost]
	    public async Task<IActionResult> Post(Position model)
	    {
		    return Ok();
	    }
    }
}
