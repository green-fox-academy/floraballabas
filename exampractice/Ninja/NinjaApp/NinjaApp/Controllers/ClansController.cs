using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NinjaApp.Models;
using NinjaApp.Services;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace NinjaApp.Controllers
{
    [Route("api/[controller]")]
    public class ClansController : Controller
    {
        private readonly IClanService clanService;

        public ClansController(IClanService clanService) // Injection of IClanService
        {
            this.clanService = clanService;
        }

        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<Clan>), 200)]
        public async Task<IActionResult> ReadAllAsync()
        {
            var allClans = await clanService.ReadAllAsync();
            return Ok(allClans);
        }
    }
}
