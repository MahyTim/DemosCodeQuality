using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FailingApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExternalUsersController : ControllerBase
    {
        private static Random RandomTiming = new Random(13);

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] string email)
        {
            if (RandomTiming.NextDouble() > 0.5)
                return BadRequest("you are unlucky and have timedout");
            return Ok(email);
        }
    }
}