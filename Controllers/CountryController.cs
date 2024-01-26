using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AuthenticationAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CountryController : ControllerBase
    {
        [Authorize]
        [HttpGet("All")]
        public IActionResult GetAllCountries()
        {
            return Ok(GlobalData.Countries);
        }
    }
}
