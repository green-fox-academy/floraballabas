using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GrootApp.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace GrootApp.Controllers
{
    public class GuardianController : Controller
    {
        [HttpGet]
        [Route("groot")]
        public IActionResult Index([FromQuery] string message)
        {
            if (!string.IsNullOrEmpty(message))
            {
                return Json(new Groot(message));
            }
            else
            {
                return new NotFoundObjectResult(new GrootError());
            }
        }
    }
}
