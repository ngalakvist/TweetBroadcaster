using Microsoft.AspNetCore.Mvc;

namespace TweetBroadcaster.Controllers
{
    public class PostController : Controller
    {
        [HttpGet("api/user")]
        public IActionResult Get()
        {
            return Ok(new { name = "Ngala Talla" });
        }
    }
}