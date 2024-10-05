using Microsoft.AspNetCore.Mvc;

namespace MinhaApi.Controllers.User{
  [ApiController]
  [Route("api/[controller]")]
    public class GetUserInfoController : ControllerBase {
      [HttpGet]
        public IActionResult Get() {
            var result = new {
                id = 1,
                name = "João da Silva",
                email = "dhbajhsbdj"
            };
            return Ok(result);
        }
    }
}