using Microsoft.AspNetCore.Mvc;

namespace RoleBasedTaskManagementSystem.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HealthController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("API is working 🚀");
        }
    }
}
