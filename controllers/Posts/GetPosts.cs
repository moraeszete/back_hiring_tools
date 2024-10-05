using Microsoft.AspNetCore.Mvc;

namespace MinhaApi.Controllers.Posts{
  [ApiController]
  [Route("api/[controller]")]
    public class GetPosts : ControllerBase {
      [HttpGet]
        public IActionResult Get() {
            var result = new {
                id = 1,
                name = "lero leor",
                identidade = "dhbkasopdijqwiojdoqdj"
            };
            return Ok(result);
        }
    }
}