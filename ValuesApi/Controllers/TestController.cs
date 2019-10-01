using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ValuesApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet]
		[Route("test")]
        public IActionResult Test()
        {
            return Ok("hello world");
        }
		
		[HttpGet]
		[Route("test")]
        public IActionResult Ping()
        {
            return Ok("pong");
        }
    }
}
