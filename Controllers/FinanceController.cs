namespace Name.Controllers
{

    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    [ApiController]
    public class FinanceController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> Get()
        { 
            return Ok("Aboba");
        }
    }
}