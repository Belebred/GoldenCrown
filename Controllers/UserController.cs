using GoldenCrown.Api.Models;
using Microsoft.AspNetCore.Mvc;

namespace GoldenCrown.Api.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        [HttpPost("register")]
        public async Task<IActionResult> Register([FromBody]RegisterRequest request)
        {
            return Ok();
        }

        [HttpPost("login")]
        public async Task<IActionResult> Login([FromBody]LoginRequest request)
        {
            
            return Ok();
        }
    }
}