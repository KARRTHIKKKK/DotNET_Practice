using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Day_05_HelloEndpoint_.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        [HttpGet("/hello")]
        public IActionResult GetHello()
        {
            return Ok("Hello, World!");
        }
    }
}